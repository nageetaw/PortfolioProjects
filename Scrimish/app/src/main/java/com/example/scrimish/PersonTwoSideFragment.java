package com.example.scrimish;

import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.Stack;

public class PersonTwoSideFragment extends Fragment {
    View view;
    ImageView player_two_pile_one, player_two_pile_two, player_two_pile_three, player_two_pile_four, player_two_pile_five;
    Player player;
    GameDeskActivity context;
    TextView playerName;
    int TOTAL_CARDS, TOTAL_WINS;
    int currentCardDrawableId, resultsOfCurentRound;
    Stack<Integer> pileOne, pileTwo, pileThree, pileFour, pileFive;
    boolean isAttacker;
    ImageView playerTwoImage;
    Stack<Integer> currentPileUnderUsage;
    int currentCardDrawableIdUnderUsage;
    boolean isYourTurn;
    static String KEY_PLAYERS_DATA = "PlayersData";

    PersonTwoSideFragment(Context context, Player player) {
        this.context = (GameDeskActivity) context;
        this.player = player;

    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

    }

    public void setPlatform() {

        String nameWithTitle = player.getPlayerName() + " : " + (player.getDefenderOrAttacker() ? "Attacker" : "Defender");
        playerName.setText(nameWithTitle);

        for (int i = 0; i < player.getPileOne().length; i++) {
            pileOne.push(player.getPileOneDrawableIds()[i]);
            pileTwo.push(player.getPileTwoDrawableIds()[i]);
            pileThree.push(player.getPileThreeDrawableIds()[i]);
            pileFour.push(player.getPileFourDrawableIds()[i]);
            pileFive.push(player.getPileFiveDrawableIds()[i]);
        }

    }

    public void initializeAll() {
        pileOne = new Stack<Integer>();
        pileTwo = new Stack<Integer>();
        pileThree = new Stack<Integer>();
        pileFour = new Stack<Integer>();
        pileFive = new Stack<Integer>();
        TOTAL_CARDS = 25;
        TOTAL_WINS = 0;
        isAttacker = player.getDefenderOrAttacker();
        isYourTurn = isAttacker;
        currentCardDrawableId = -1;
        resultsOfCurentRound = -1;
        playerTwoImage = view.findViewById(R.id.playerTwoImage);
        playerTwoImage.setImageResource(player.getGender() ? R.drawable.female : R.drawable.male);
        playerName = view.findViewById(R.id.playerTwoName);
        player_two_pile_one = view.findViewById(R.id.player_two_pile_one);
        player_two_pile_two = view.findViewById(R.id.player_two_pile_two);
        player_two_pile_three = view.findViewById(R.id.player_two_pile_three);
        player_two_pile_four = view.findViewById(R.id.player_two_pile_four);
        player_two_pile_five = view.findViewById(R.id.player_two_pile_five);
        if (!isYourTurn) {
            setEnablePilesClick(false);
        }
    }

    public void showChard(int id, ImageView imageView, Stack<Integer> currentUsedPile) {
        currentCardDrawableId = id;
        Thread thread = new Thread(new Runnable() {
            @Override
            public void run() {

                imageView.post(new Runnable() {
                    @Override
                    public void run() {
                        imageView.setImageResource(id);
                    }
                });

                try {
                    Log.d("sleep", "before sleep");
                    Thread.sleep(1000);
                    Log.d("sleep", "after sleep");

                } catch (Exception e) {
                    e.printStackTrace();
                }
                imageView.post(new Runnable() {
                    @Override
                    public void run() {
                        if (currentUsedPile.isEmpty()) {
                            imageView.setImageResource(R.drawable.back_cover);
                        } else {
                            imageView.setImageResource(R.drawable.green);
                        }
                        if (isAttacker) {
                            if (getResources().getResourceEntryName(id).equals(Constants.SHIELD_CARD_KEY)) {
                                Toast.makeText(context, "You can't attack with a shield card", Toast.LENGTH_LONG).show();
                            } else {
                                resultsOfCurentRound = context.setPlayerTwoDefendedCard(id);
                                currentPileUnderUsage = currentUsedPile;
                                currentCardDrawableIdUnderUsage = id;
                                // after attcaking player need to wait for defender to attack
                                waitForDefender();
                            }
                        } else {
                            // you are a defender
                            resultsOfCurentRound = context.setPlayerTwoDefendedCard(id);
                            if (resultsOfCurentRound == Constants.DEFENDER_WINS_THE_ROUND ||
                                    resultsOfCurentRound == Constants.BOTH_CARDS_RETURNS_TO_PILE) {
                                currentUsedPile.push(id);
                            } else if (resultsOfCurentRound == Constants.ATTACKER_WINS_THE_ROUND ||
                                    resultsOfCurentRound == Constants.BOTH_CARDS_ARE_DISCARDED) {
                                // do nothing
                                context.setPlayerTwoDiscardedCard();
                            } else if (resultsOfCurentRound == Constants.DEFENDER_WINS_THE_GAME) {
                                // you win the game
                                InformAboutWinner();
                            } else if (resultsOfCurentRound == Constants.ATTACKER_WINS_THE_GAME) {
                                // you loose the game
                            }
                            waitForDefender();
                        }


                    }
                });
            }
        });
        thread.start();

    }

    public void InformAboutWinner(){
        AlertDialog alertDialog = new AlertDialog.Builder(context).create();
        alertDialog.setTitle("Results");
        alertDialog.setMessage(player.getPlayerName() + " wins the game");
        alertDialog.setButton(AlertDialog.BUTTON_NEUTRAL, "OK",
                new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int which) {
                        dialog.dismiss();
                        SharedPreferences settings = context.getSharedPreferences(KEY_PLAYERS_DATA, Context.MODE_PRIVATE);
                        settings.edit().clear().commit();
                        Intent intent = new Intent(context, MainActivity.class);
                        intent.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
                        startActivity(intent);
                    }
                });
        alertDialog.show();
    }

    public void performYourTurn() {
        isYourTurn = true;
        setEnablePilesClick(true);
    }

    public void waitForDefender() {
        isYourTurn = false;
        setEnablePilesClick(false);
    }

    public void setEnablePilesClick(boolean value) {
        player_two_pile_one.setEnabled(value);
        player_two_pile_two.setEnabled(value);
        player_two_pile_three.setEnabled(value);
        player_two_pile_four.setEnabled(value);
        player_two_pile_five.setEnabled(value);
    }

    public void performResultAnalysis(int resultCode) {
        if (resultCode == Constants.ATTACKER_WINS_THE_GAME) {
            //you win the game
            InformAboutWinner();
        } else if (resultCode == Constants.DEFENDER_WINS_THE_GAME) {
            // you loose the game
        } else if (resultCode == Constants.BOTH_CARDS_RETURNS_TO_PILE ||
                resultCode == Constants.ATTACKER_WINS_THE_ROUND) {
            currentPileUnderUsage.push(currentCardDrawableIdUnderUsage);
        } else if (resultCode == Constants.DEFENDER_WINS_THE_ROUND ||
                resultCode == Constants.BOTH_CARDS_ARE_DISCARDED) {
            // do noting
            context.setPlayerTwoDiscardedCard();
        }
        performYourTurn();
    }

    public void discardCard(Stack<Integer> currentUsedPile, ImageView imageView) {
        if (!currentUsedPile.empty()) {
            currentUsedPile.pop();
            context.setPlayerTwoDiscardedCard();
        } else {
            imageView.setImageResource(R.drawable.back_cover);
            imageView.setEnabled(false);
        }
    }

    public void attachListenersToAll() {



        player_two_pile_one.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (!pileOne.isEmpty())
                    showChard(pileOne.pop(), player_two_pile_one, pileOne);
            }
        });

        player_two_pile_one.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View v) {
                if (!pileOne.isEmpty())
                    discardCard(pileOne, player_two_pile_one);
                return true;
            }
        });

        player_two_pile_two.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                if (!pileTwo.isEmpty())
                    showChard(pileTwo.pop(), player_two_pile_two, pileTwo);
            }
        });
        player_two_pile_two.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View v) {

                if (!pileTwo.isEmpty())
                    discardCard(pileTwo, player_two_pile_two);
                return true;
            }
        });

        player_two_pile_three.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                if (!pileThree.isEmpty())
                    showChard(pileThree.pop(), player_two_pile_three, pileThree);
            }
        });
        player_two_pile_three.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View v) {

                if (!pileThree.isEmpty())
                    discardCard(pileThree, player_two_pile_three);
                return true;
            }
        });


        player_two_pile_four.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                if (!pileFour.isEmpty())
                    showChard(pileFour.pop(), player_two_pile_four, pileFour);
            }
        });
        player_two_pile_four.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View v) {

                if (!pileFour.isEmpty())
                    discardCard(pileFour, player_two_pile_four);
                return true;
            }
        });


        player_two_pile_five.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                if (!pileFive.isEmpty())
                    showChard(pileFive.pop(), player_two_pile_five, pileFive);
            }
        });
        player_two_pile_five.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View v) {

                if (!pileFive.isEmpty())
                    discardCard(pileFive, player_two_pile_five);
                return true;
            }
        });
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        view = inflater.inflate(R.layout.fragment_person_two_side, container, false);

        initializeAll();
        setPlatform();
        attachListenersToAll();


        return view;
    }
}