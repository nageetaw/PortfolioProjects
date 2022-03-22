package com.example.scrimish;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.provider.ContactsContract;
import android.util.Log;
import android.widget.ImageView;

import com.google.gson.Gson;

public class ReviewAllPilesActivity extends AppCompatActivity {
    Gson gson;
    Player currentPlayer;
    SharedPreferences sharedPreferences;
    Intent filePilesIntent;
    static String KEY_PLAYER_NUMBER = "playerNumber", KEY_PLAYERS_DATA = "PlayersData";
    String VALUE_PLAYER_NUMBER;
    ImageView[] pileOne;
    ImageView[] pileTwo;
    ImageView[] pileThree;
    ImageView[] pileFour;
    ImageView[] pileFive;
    static int TOTAL_CARDS_IN_PILE = 5;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_review_all_piles);

        initializeAll();
        filePilesIntent = getIntent();

        try {
            gson = new Gson();
            sharedPreferences = getSharedPreferences(KEY_PLAYERS_DATA, MODE_PRIVATE);

            VALUE_PLAYER_NUMBER = filePilesIntent.getStringExtra(KEY_PLAYER_NUMBER);
            String gsonString = sharedPreferences.getString(VALUE_PLAYER_NUMBER, "");
            currentPlayer = gson.fromJson(gsonString, Player.class);

            SetAllCards();
        } catch (Exception e) {
            Log.d("error", "in one create" + e.getMessage());
        }

    }

    public void initializeAll() {
        pileOne = new ImageView[TOTAL_CARDS_IN_PILE];
        pileTwo = new ImageView[TOTAL_CARDS_IN_PILE];
        pileThree = new ImageView[TOTAL_CARDS_IN_PILE];
        pileFive = new ImageView[TOTAL_CARDS_IN_PILE];
        pileFour = new ImageView[TOTAL_CARDS_IN_PILE];


        pileOne[0]= (ImageView) findViewById(R.id.pileOneCard1);
        pileOne[1]=(ImageView) findViewById(R.id.pileOneCard2);
        pileOne[2]=(ImageView) findViewById(R.id.pileOneCard3);
        pileOne[3]=(ImageView) findViewById(R.id.pileOneCard4);
        pileOne[4]=(ImageView) findViewById(R.id.pileOneCard5);

        pileTwo[0]=(ImageView) findViewById(R.id.pileTwoCard1);
        pileTwo[1]=(ImageView) findViewById(R.id.pileTwoCard2);
        pileTwo[2]=(ImageView) findViewById(R.id.pileTwoCard3);
        pileTwo[3]=(ImageView) findViewById(R.id.pileTwoCard4);
        pileTwo[4]=(ImageView) findViewById(R.id.pileTwoCard5);

        pileThree[0]=(ImageView) findViewById(R.id.pileThreeCard1);
        pileThree[1]=(ImageView) findViewById(R.id.pileThreeCard2);
        pileThree[2]=(ImageView) findViewById(R.id.pileThreeCard3);
        pileThree[3]=(ImageView) findViewById(R.id.pileThreeCard4);
        pileThree[4]=(ImageView) findViewById(R.id.pileThreeCard5);


        pileFour[0]=(ImageView) findViewById(R.id.pileFourCard1);
        pileFour[1]=(ImageView) findViewById(R.id.pileFourCard2);
        pileFour[2]=(ImageView) findViewById(R.id.pileFourCard3);
        pileFour[3]=(ImageView) findViewById(R.id.pileFourCard4);
        pileFour[4]=(ImageView) findViewById(R.id.pileFourCard5);

        pileFive[0]=(ImageView) findViewById(R.id.pileFiveCard1);
        pileFive[1]=(ImageView) findViewById(R.id.pileFiveCard2);
        pileFive[2]=(ImageView) findViewById(R.id.pileFiveCard3);
        pileFive[3]=(ImageView) findViewById(R.id.pileFiveCard4);
        pileFive[4]=(ImageView) findViewById(R.id.pileFiveCard5);
    }

    public void SetAllCards() {

        try {
            int[] pileOneIds = currentPlayer.getPileOneDrawableIds();
           for(int i=0;i<pileOneIds.length;i++){
               pileOne[i].setImageResource(pileOneIds[i]);
           }

        } catch (Exception e) {
            Log.d("error", e.getMessage());
        }

        try {
            int[] pileTwoIds = currentPlayer.getPileTwoDrawableIds();
            for(int i=0;i<pileTwoIds.length;i++){
                pileTwo[i].setImageResource(pileTwoIds[i]);
            }
        } catch (Exception e) {
            Log.d("error", e.getMessage());
        }

        try {
            int[] pileThreeIds = currentPlayer.getPileThreeDrawableIds();
            for(int i=0;i<pileThreeIds.length;i++){
                pileThree[i].setImageResource(pileThreeIds[i]);
            }
        } catch (Exception e) {
            Log.d("error", e.getMessage());
        }
        try {
            int[] pileFourIds = currentPlayer.getPileFourDrawableIds();
            for(int i=0;i<pileFourIds.length;i++){
                pileFour[i].setImageResource(pileFourIds[i]);
            }
        } catch (Exception e) {
            Log.d("error", e.getMessage());
        }
        try {
            int[] pileFiveIds = currentPlayer.getPileFiveDrawableIds();
            for(int i=0;i<pileFiveIds.length;i++){
                pileFive[i].setImageResource(pileFiveIds[i]);
            }
        } catch (Exception e) {
            Log.d("error", e.getMessage());
        }
    }
}