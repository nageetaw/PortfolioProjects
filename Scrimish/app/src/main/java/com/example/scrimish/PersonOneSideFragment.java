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

import com.google.gson.Gson;

import java.util.Stack;

public class PersonOneSideFragment extends Fragment {

    View view;
    ImageView player_one_pile_one, player_one_pile_two, player_one_pile_three, player_one_pile_four, player_one_pile_five;
    GameDeskActivity context;
    ImageView PlayerOneImage;
    Player player;
    int currentCardDrawableId;
    TextView playerName;
    int TOTAL_CARDS, TOTAL_WINS, resultsOfCurentRound;
    Stack<Integer> pileOne, pileTwo, pileThree, pileFour, pileFive;
    boolean isAttacker;


    static String KEY_PLAYER_NUMBER = "playerNumber", KEY_PLAYERS_DATA = "PlayersData";
    SharedPreferences sharedPreferences;
    SharedPreferences.Editor editor;
    Stack<Integer> currentPileUnderUsage;
    int currentCardDrawableIdUnderUsage;
    boolean isYourTurn;

    PersonOneSideFragment(Context context, Player player) {
        this.context = (GameDeskActivity) context;
        this.player = player;

    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

    }

    public void initializeAll() {
        sharedPreferences = context.getSharedPreferences(KEY_PLAYERS_DATA, Context.MODE_PRIVATE);
        editor = sharedPreferences.edit();
        pileOne = new Stack<Integer>();
        pileTwo = new Stack<Integer>();
        pileThree = new Stack<Integer>();
        pileFour = new Stack<Integer>();
        pileFive = new Stack<Integer>();
        resultsOfCurentRound = -1;
        currentCardDrawableId = -1;
        TOTAL_CARDS = 25;
        TOTAL_WINS = 0;
        PlayerOneImage = view.findViewById(R.id.playerOneImage);
        PlayerOneImage.setImageResource(player.getGender() ? R.drawable.female : R.drawable.male);


        isAttacker = player.getDefenderOrAttacker();
        isYourTurn = isAttacker; // if you are attacker then first turn will be yours
        playerName = view.findViewById(R.id.playerOneName);
        player_one_pile_one = view.findViewById(R.id.player_one_pile_one);
        player_one_pile_two = view.findViewById(R.id.player_one_pile_two);
        player_one_pile_three = view.findViewById(R.id.player_one_pile_three);
        player_one_pile_four = view.findViewById(R.id.player_one_pile_four);
        player_one_pile_five = view.findViewById(R.id.player_one_pile_five);

        if (!isYourTurn) {
            setEnablePilesClick(false);
        }
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
                            imageView.setImageResource(R.drawable.blue);
                        }
                        if (isAttacker) {
                            /**
                             * Attacker Attacks
                             * wait for defender to attack
                             * game desk allow second player to attack now
                             *
                             **/
                            // attacker needs to wait for results
                            if (getResources().getResourceEntryName(id).equals(Constants.SHIELD_CARD_KEY)) {
                                Toast.makeText(context, "You can not attack with shield card", Toast.LENGTH_LONG).show();
                            } else {
                                resultsOfCurentRound = context.setPlayerOneDefendedCard(id);
                                // need to compare here
                                currentPileUnderUsage = currentUsedPile;
                                currentCardDrawableIdUnderUsage = id;
                                // after attcaking player need to wait for defender to attack
                                waitForDefender();
                            }
                        } else {
                            // you are a defender
                            resultsOfCurentRound = context.setPlayerOneDefendedCard(id);
                            if (resultsOfCurentRound == Constants.DEFENDER_WINS_THE_ROUND ||
                                    resultsOfCurentRound == Constants.BOTH_CARDS_RETURNS_TO_PILE) {
                                currentUsedPile.push(id);
                            } else if (resultsOfCurentRound == Constants.ATTACKER_WINS_THE_ROUND ||
                                    resultsOfCurentRound == Constants.BOTH_CARDS_ARE_DISCARDED) {
                                context.setPlayerOneDiscardedCard();
                                // do nothing
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

    public void performYourTurn() {
        isYourTurn = true;
        setEnablePilesClick(true);
    }

    public void waitForDefender() {
        isYourTurn = false;
        setEnablePilesClick(false);
    }

    public void setEnablePilesClick(boolean value) {
        player_one_pile_one.setEnabled(value);
        player_one_pile_two.setEnabled(value);
        player_one_pile_three.setEnabled(value);
        player_one_pile_four.setEnabled(value);
        player_one_pile_five.setEnabled(value);
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
    public void performResultsAnalysis(int resultCode) {
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
            context.setPlayerOneDiscardedCard();
        }
        performYourTurn();
    }

    public void discardCard(Stack<Integer> currentUsedPile, ImageView imageView) {
        if (!currentUsedPile.empty()) {
            currentUsedPile.pop();
            context.setPlayerOneDiscardedCard();
        } else {
            imageView.setEnabled(false);
            imageView.setImageResource(R.drawable.back_cover);
        }
    }

    public void attachListenersToAll() {



        player_one_pile_one.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (!pileOne.isEmpty()) {
                    showChard(pileOne.pop(), player_one_pile_one, pileOne);

                }
            }
        });
        player_one_pile_one.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View v) {
                if (!pileOne.isEmpty()) {
                    discardCard(pileOne, player_one_pile_one);
                }
                return true;
            }
        });


        player_one_pile_two.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (!pileTwo.isEmpty()) {
                    showChard(pileTwo.pop(), player_one_pile_two, pileTwo);
                }
            }
        });
        player_one_pile_two.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View v) {
                if (!pileTwo.isEmpty())
                    discardCard(pileTwo, player_one_pile_two);
                return true;
            }
        });


        player_one_pile_three.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (!pileThree.isEmpty())
                    showChard(pileThree.pop(), player_one_pile_three, pileThree);
            }
        });
        player_one_pile_three.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View v) {
                if (!pileThree.isEmpty())
                    discardCard(pileThree, player_one_pile_three);
                return true;
            }
        });


        player_one_pile_four.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (!pileFour.isEmpty())
                    showChard(pileFour.pop(), player_one_pile_four, pileFour);
            }
        });

        player_one_pile_four.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View v) {
                if (!pileFour.isEmpty())
                    discardCard(pileFour, player_one_pile_four);
                return true;
            }
        });


        player_one_pile_five.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (!pileFive.isEmpty())
                    showChard(pileFive.pop(), player_one_pile_five, pileFive);
            }
        });
        player_one_pile_five.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View v) {
                if (!pileFive.isEmpty())
                    discardCard(pileFive, player_one_pile_five);
                return true;
            }
        });
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        view = inflater.inflate(R.layout.fragment_person_one_side, container, false);

        initializeAll();

        setPlatform();

        attachListenersToAll();

        return view;
    }
}