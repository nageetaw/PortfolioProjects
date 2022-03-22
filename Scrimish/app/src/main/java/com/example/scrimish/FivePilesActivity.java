package com.example.scrimish;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.os.Parcelable;
import android.speech.RecognizerIntent;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;
import android.widget.Toast;

import com.google.gson.Gson;

import java.util.ArrayList;

public class FivePilesActivity extends AppCompatActivity {

    Intent personDetailIntent;
    TextView welcomeUserName;
    boolean isFivePilesSelected;
    ImageButton pileOne, pileTwo, pileThree, pileFour, pileFive;
    Intent pickCardsIntent;


    Button nextBtnOnSelectPile, reviewPilesBtn;
    int[][] fivePilesCards;

    SharedPreferences sharedPreferences;
    SharedPreferences.Editor editor;
    Gson gson;

    Player currentPlayer;
    String VALUE_PLAYER_NUMBER;

    static String KEY_PLAYERS_DATA = "PlayersData", KEY_PLAYER_NAME = "playerName", KEY_PLAYER_NUMBER = "playerNumber", KEY_SELECTED_CARDS = "selectedCards",
            KEY_SELECTED_CARDS_DRAWABLE_IDS = "selectedCardsDrawableID", KEY_REQUEST_CODE = "requestCode";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_five_piles);

        personDetailIntent = getIntent();

        welcomeUserName = findViewById(R.id.welcomeUserName);
        welcomeUserName.setText("Welcome " + personDetailIntent.getStringExtra(KEY_PLAYER_NAME));
        VALUE_PLAYER_NUMBER = personDetailIntent.getStringExtra(KEY_PLAYER_NUMBER);// playerOne

        Initialize();

        sharedPreferences = getSharedPreferences(KEY_PLAYERS_DATA, MODE_PRIVATE);
        editor = sharedPreferences.edit();

        gson = new Gson();
        String json = sharedPreferences.getString(VALUE_PLAYER_NUMBER, "");//VALUE_PLAYER_NUMBER=playerOne
        currentPlayer = gson.fromJson(json, Player.class);

        checkIfFivePilesSelected();


    }


    public void checkIfFivePilesSelected() {

        if (currentPlayer.getAllPilesAreSelected()) {
            isFivePilesSelected = true;
            setEnableValueForAllButtons(true);
        }
    }

    public void setEnableValueForAllButtons(boolean flag) {
        pileTwo.setEnabled(flag);
        pileThree.setEnabled(flag);
        pileFive.setEnabled(flag);
        pileFour.setEnabled(flag);
        nextBtnOnSelectPile.setEnabled(flag);
    }

    public void Initialize() {
        isFivePilesSelected = false;
        pileOne = findViewById(R.id.pileOne);
        pileTwo = findViewById(R.id.pileTwo);
        pileThree = findViewById(R.id.pileThree);
        pileFour = findViewById(R.id.pileFour);
        pileFive = findViewById(R.id.pileFive);
        nextBtnOnSelectPile = findViewById(R.id.nextBtnOnSelectPile);

        setEnableValueForAllButtons(false);

        fivePilesCards = new int[5][5];

        reviewPilesBtn = findViewById(R.id.reviewAllPilesButton);

    }

    public void onPileOneClick(View v) {
        pickCardsIntent = new Intent(this, pickCardsActivity.class);
        pickCardsIntent.putExtra(KEY_REQUEST_CODE, R.string.PILE_ONE_REQUEST_CODE);
        pickCardsIntent.putExtra(KEY_PLAYER_NUMBER, VALUE_PLAYER_NUMBER);
        startActivityForResult(pickCardsIntent, R.string.PILE_ONE_REQUEST_CODE);
        pileTwo.setEnabled(true);

    }

    public void onPileTwoClick(View v) {
        pickCardsIntent = new Intent(this, pickCardsActivity.class);
        pickCardsIntent.putExtra(KEY_REQUEST_CODE, R.string.PILE_TWO_REQUEST_CODE);
        pickCardsIntent.putExtra(KEY_PLAYER_NUMBER, VALUE_PLAYER_NUMBER);
        startActivityForResult(pickCardsIntent, R.string.PILE_TWO_REQUEST_CODE);
        pileThree.setEnabled(true);
    }

    public void onPileThreeClick(View v) {
        pickCardsIntent = new Intent(this, pickCardsActivity.class);
        pickCardsIntent.putExtra(KEY_REQUEST_CODE, R.string.PILE_THREE_REQUEST_CODE);
        pickCardsIntent.putExtra(KEY_PLAYER_NUMBER, VALUE_PLAYER_NUMBER);
        startActivityForResult(pickCardsIntent, R.string.PILE_THREE_REQUEST_CODE);
        pileFour.setEnabled(true);
    }

    public void onPileFourClick(View v) {
        pickCardsIntent = new Intent(this, pickCardsActivity.class);
        pickCardsIntent.putExtra(KEY_REQUEST_CODE, R.string.PILE_FOUR_REQUEST_CODE);
        pickCardsIntent.putExtra(KEY_PLAYER_NUMBER, VALUE_PLAYER_NUMBER);
        startActivityForResult(pickCardsIntent, R.string.PILE_FOUR_REQUEST_CODE);
        pileFive.setEnabled(true);
    }

    public void onPileFiveClick(View v) {
        pickCardsIntent = new Intent(this, pickCardsActivity.class);
        pickCardsIntent.putExtra(KEY_REQUEST_CODE, R.string.PILE_FIVE_REQUEST_CODE);
        pickCardsIntent.putExtra(KEY_PLAYER_NUMBER, VALUE_PLAYER_NUMBER);
        startActivityForResult(pickCardsIntent, R.string.PILE_FIVE_REQUEST_CODE);


    }

    public void ResetDataInSharedPreference() {
        Gson resetDataGson = new Gson();
        String resetJsonData = resetDataGson.toJson(currentPlayer);
        editor.putString(VALUE_PLAYER_NUMBER, resetJsonData);
        editor.commit();
    }

    public void onReviewPilesClick(View view) {
        Intent intent = new Intent(this, ReviewAllPilesActivity.class);
        intent.putExtra(KEY_PLAYER_NUMBER, VALUE_PLAYER_NUMBER);
        startActivity(intent);
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);

        if (requestCode == R.string.PILE_ONE_REQUEST_CODE) {

            Toast.makeText(getApplicationContext(), "one", Toast.LENGTH_SHORT).show();
            try {
                currentPlayer.setPileOne(data.getIntArrayExtra(KEY_SELECTED_CARDS));
                currentPlayer.setPileOneDrawableIds(data.getIntArrayExtra(KEY_SELECTED_CARDS_DRAWABLE_IDS));
                ResetDataInSharedPreference();
            } catch (Exception e) {
                Log.d("error", "i'm back in pile one" + e.getMessage());
            }


        } else if (requestCode == R.string.PILE_TWO_REQUEST_CODE) {

            Toast.makeText(getApplicationContext(), "two", Toast.LENGTH_SHORT).show();
            try {


                currentPlayer.setPileTwoDrawableIds(data.getIntArrayExtra(KEY_SELECTED_CARDS_DRAWABLE_IDS));
                currentPlayer.setPileTwo(data.getIntArrayExtra(KEY_SELECTED_CARDS));

                ResetDataInSharedPreference();
            } catch (Exception e) {
                Log.d("error", "i'm back in pile one" + e.getMessage());
            }


        } else if (requestCode == R.string.PILE_THREE_REQUEST_CODE) {

            Toast.makeText(getApplicationContext(), "three", Toast.LENGTH_SHORT).show();
            try {
                currentPlayer.setPileThreeDrawableIds(data.getIntArrayExtra(KEY_SELECTED_CARDS_DRAWABLE_IDS));
                currentPlayer.setPileThree(data.getIntArrayExtra(KEY_SELECTED_CARDS));

                ResetDataInSharedPreference();
            } catch (Exception e) {
                Log.d("error", "i'm back in pile one" + e.getMessage());
            }


        } else if (requestCode == R.string.PILE_FOUR_REQUEST_CODE) {

            Toast.makeText(getApplicationContext(), "four", Toast.LENGTH_SHORT).show();
            try {
                currentPlayer.setPileFourDrawableIds(data.getIntArrayExtra(KEY_SELECTED_CARDS_DRAWABLE_IDS));
                currentPlayer.setPileFour(data.getIntArrayExtra(KEY_SELECTED_CARDS));

                ResetDataInSharedPreference();
            } catch (Exception e) {
                Log.d("error", "i'm back in pile one" + e.getMessage());
            }


        } else if (requestCode == R.string.PILE_FIVE_REQUEST_CODE) {

            Toast.makeText(getApplicationContext(), "five", Toast.LENGTH_SHORT).show();

            try {
                currentPlayer.setPileFiveDrawableIds(data.getIntArrayExtra(KEY_SELECTED_CARDS_DRAWABLE_IDS));
                currentPlayer.setPileFive(data.getIntArrayExtra(KEY_SELECTED_CARDS));
                nextBtnOnSelectPile.setEnabled(true);
                checkForDefenderOrAttacker();
                ResetDataInSharedPreference();


            } catch (Exception e) {
                Log.d("error", "i'm back in pile one" + e.getMessage());
            }

        }
    }


    public void checkForDefenderOrAttacker() {
        try {
            //Log.d("message","a");
            String json1 = sharedPreferences.getString("playerOne", "");
            //Log.d("message","aa");
            Player PlayerOne = gson.fromJson(json1, Player.class);
            //Log.d("message","aaa");
            String json2 = sharedPreferences.getString("playerTwo", "");
            //Log.d("message","aaaa");
            Player PlayerTwo = gson.fromJson(json2, Player.class);
            //  Log.d("message","aaaaa");

            // check if player one and player two are not null


            if (PlayerOne != null && currentPlayer.getPlayerNo() == PlayerOne.getPlayerNo() && currentPlayer.getAllPilesAreSelected()) {
                if(PlayerTwo == null) {
                    currentPlayer.setDefenderOrAttacker(true);
                }else
                    currentPlayer.setDefenderOrAttacker(false);
            }

            else if (PlayerTwo != null && currentPlayer.getPlayerNo() == PlayerTwo.getPlayerNo() && currentPlayer.getAllPilesAreSelected()) {
                if(PlayerOne == null) {
                    currentPlayer.setDefenderOrAttacker(true);
                }else
                    currentPlayer.setDefenderOrAttacker(false);
            }


        } catch (Exception e) {
            Log.d("error", e.getMessage());
        }
    }

    public void onNextBtnOnSelectPileClick(View view) {
        Intent selectPersonActivityIntent = new Intent(this, SelectPersonActivity.class);
        startActivity(selectPersonActivityIntent);

    }
}