package com.example.scrimish;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.graphics.Color;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.os.Parcelable;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.Toast;

import com.google.gson.Gson;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

public class pickCardsActivity extends AppCompatActivity {

    // currently selected by user : SELECTED_CARD_BACKGROUND
    // currenlty deselected by user: DESELECTED_CARD_BACKGROUND
    // user can't select: DISABLED_CARD_BACKGROUND

    static String SELECTED_CARD_BACKGROUND = "#f5bf42",
            DESELECTED_CARD_BACKGROUND = "#FFFFFF",
            DISABLED_CARD_BACKGROUND = "#a4aaab";

    static String KEY_PLAYERS_DATA = "PlayersData", KEY_PLAYER_NAME = "playerName", KEY_PLAYER_NUMBER = "playerNumber", KEY_SELECTED_CARDS = "selectedCards",
            KEY_SELECTED_CARDS_DRAWABLE_IDS = "selectedCardsDrawableID",KEY_REQUEST_CODE="requestCode";
    int counter;
    int[] fiveSelectedCards;

    Button resetBtn, nextPileCardSelectBtn;
    static int TOTAL_CARDS = 25;

    ImageView[] cards;
    int[] CardIDS;
    int[] CardsDrawableIDS;
    boolean[] isCardSelected;
    boolean[] isCardIsAllowedToSelect;
    int[] tempArrayForPreviouslyUserSelectedCards;

    SharedPreferences sharedPreferences;
    Intent fivePilesActivityIntent;

    Gson gson;
    String VALUE_PLAYER_NUMBER;
    Player currentPlayer;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pick_cards);

        counter = 0;
        resetBtn = findViewById(R.id.resetBtn);
        nextPileCardSelectBtn = findViewById(R.id.nextPileCardSelectBtn);

        resetBtn.setEnabled(false);
        nextPileCardSelectBtn.setEnabled(false);

        cards = new ImageView[TOTAL_CARDS];
        isCardSelected = new boolean[TOTAL_CARDS];
        CardIDS = new int[TOTAL_CARDS];
        isCardIsAllowedToSelect = new boolean[TOTAL_CARDS];
        tempArrayForPreviouslyUserSelectedCards = new int[TOTAL_CARDS];
        CardsDrawableIDS = new int[TOTAL_CARDS];


        fiveSelectedCards = new int[5];


        fivePilesActivityIntent = getIntent();

        try {
            gson = new Gson();
            VALUE_PLAYER_NUMBER = fivePilesActivityIntent.getStringExtra(KEY_PLAYER_NUMBER);
            sharedPreferences = getSharedPreferences(KEY_PLAYERS_DATA, MODE_PRIVATE);
            String gsonString = sharedPreferences.getString(VALUE_PLAYER_NUMBER, "");

            currentPlayer = gson.fromJson(gsonString, Player.class);
            Log.d("message", "element " + currentPlayer.getPileOne()[0]);
        } catch (Exception e) {
            Log.d("error", "in pick card create" + e.getMessage());
        }


        // first get all cards by ids
        getAllCardsByID();
        // second check if they are allowed to selected or not
        CheckIsCardIsAllowedToSelect();
//        // deleselect all cards initially so that user can select
        deSelectAllCards();
//


    }


    public void CheckIsCardIsAllowedToSelect() {


        fillTempArrayForPreviouslyUserSelectedCards();
        boolean isFound;
        for (int i = 0; i < TOTAL_CARDS; i++) {
            Log.d("message", "--------------------");
            isFound = false;
            for (int j = 0; j < TOTAL_CARDS; j++) {
                Log.d("message", "" + CardIDS[i] + " : " + tempArrayForPreviouslyUserSelectedCards[j]);
                if (CardIDS[i] == tempArrayForPreviouslyUserSelectedCards[j]) {
                    isFound = true;
                    Log.d("message", "found" + tempArrayForPreviouslyUserSelectedCards[j]);
                    break;
                }
            }

            if (isFound) {
                isCardIsAllowedToSelect[i] = (false);
                cards[i].setEnabled(false);
                cards[i].setBackgroundColor(Color.parseColor(DISABLED_CARD_BACKGROUND));
            } else {
                isCardIsAllowedToSelect[i] = (true);
            }


        }
    }

    public void fillTempArrayForPreviouslyUserSelectedCards() {
        int counterForTempArrayForPreviouslyUserSelectedCards = 0;

        try {
            for (int i = 0; i < currentPlayer.getPileOne().length; i++) {
                tempArrayForPreviouslyUserSelectedCards[counterForTempArrayForPreviouslyUserSelectedCards] =
                        currentPlayer.getPileOne()[i];
                counterForTempArrayForPreviouslyUserSelectedCards++;
            }
        } catch (Exception e) {
            Log.d("error", e.getMessage());
        }
        for (int i = 0; i < currentPlayer.getPileTwo().length; i++) {
            tempArrayForPreviouslyUserSelectedCards[counterForTempArrayForPreviouslyUserSelectedCards] = currentPlayer.getPileTwo()[i];
            counterForTempArrayForPreviouslyUserSelectedCards++;
        }
        for (int i = 0; i < currentPlayer.getPileThree().length; i++) {
            tempArrayForPreviouslyUserSelectedCards[counterForTempArrayForPreviouslyUserSelectedCards] = currentPlayer.getPileThree()[i];
            counterForTempArrayForPreviouslyUserSelectedCards++;
        }
        for (int i = 0; i < currentPlayer.getPileFour().length; i++) {
            tempArrayForPreviouslyUserSelectedCards[counterForTempArrayForPreviouslyUserSelectedCards] = currentPlayer.getPileFour()[i];
            counterForTempArrayForPreviouslyUserSelectedCards++;
        }
        for (int i = 0; i < currentPlayer.getPileFive().length; i++) {
            tempArrayForPreviouslyUserSelectedCards[counterForTempArrayForPreviouslyUserSelectedCards] = currentPlayer.getPileFive()[i];
            counterForTempArrayForPreviouslyUserSelectedCards++;
        }
    }

    public void deSelectAllCards() {
        for (int i = 0; i < TOTAL_CARDS; i++) {
            isCardSelected[i] = false;
        }
    }

    public void getAllCardsByID() {
        cards[0] = findViewById(R.id.daggerCardOne);
        CardIDS[0] = R.id.daggerCardOne;
        CardsDrawableIDS[0] = R.drawable.one;

        cards[1] = findViewById(R.id.daggerCardTwo);
        CardIDS[1] = R.id.daggerCardTwo;
        CardsDrawableIDS[1] = R.drawable.one;


        cards[2] = findViewById(R.id.daggerCardThree);
        CardIDS[2] = R.id.daggerCardThree;
        CardsDrawableIDS[2] = R.drawable.one;

        cards[3] = findViewById(R.id.daggerCardFour);
        CardIDS[3] = R.id.daggerCardFour;
        CardsDrawableIDS[3] = R.drawable.one;

        cards[4] = findViewById(R.id.daggerCardFive);
        CardIDS[4] = R.id.daggerCardFive;
        CardsDrawableIDS[4] = R.drawable.one;

        cards[5] = findViewById(R.id.swordCardOne);
        CardIDS[5] = R.id.swordCardOne;
        CardsDrawableIDS[5] = R.drawable.two;

        cards[6] = findViewById(R.id.swordCardTwo);
        CardIDS[6] = R.id.swordCardTwo;
        CardsDrawableIDS[6] = R.drawable.two;

        cards[7] = findViewById(R.id.swordCardThree);
        CardIDS[7] = R.id.swordCardThree;
        CardsDrawableIDS[7] = R.drawable.two;

        cards[8] = findViewById(R.id.swordCardFour);
        CardIDS[8] = R.id.swordCardFour;
        CardsDrawableIDS[8] = R.drawable.two;

        cards[9] = findViewById(R.id.swordCardFive);
        CardIDS[9] = R.id.swordCardFive;
        CardsDrawableIDS[9] = R.drawable.two;

        cards[10] = findViewById(R.id.morningStartCardOne);
        CardIDS[10] = R.id.morningStartCardOne;
        CardsDrawableIDS[10] = R.drawable.three;

        cards[11] = findViewById(R.id.morningStartCardTwo);
        CardIDS[11] = R.id.morningStartCardTwo;
        CardsDrawableIDS[11] = R.drawable.three;

        cards[12] = findViewById(R.id.morningStartCardThree);
        CardIDS[12] = R.id.morningStartCardThree;
        CardsDrawableIDS[12] = R.drawable.three;

        cards[13] = findViewById(R.id.warAxeCardOne);
        CardIDS[13] = R.id.warAxeCardOne;
        CardsDrawableIDS[13] = R.drawable.four;

        cards[14] = findViewById(R.id.warAxeCardTwo);
        CardIDS[14] = R.id.warAxeCardTwo;
        CardsDrawableIDS[14] = R.drawable.four;

        cards[15] = findViewById(R.id.warAxeCardThree);
        CardIDS[15] = R.id.warAxeCardThree;
        CardsDrawableIDS[15] = R.drawable.four;

        cards[16] = findViewById(R.id.halberdCardOne);
        CardIDS[16] = R.id.halberdCardOne;
        CardsDrawableIDS[16] = R.drawable.five;

        cards[17] = findViewById(R.id.halberdCardTwo);
        CardIDS[17] = R.id.halberdCardTwo;
        CardsDrawableIDS[17] = R.drawable.five;

        cards[18] = findViewById(R.id.longSwordCardOne);
        CardIDS[18] = R.id.longSwordCardOne;
        CardsDrawableIDS[18] = R.drawable.six;

        cards[19] = findViewById(R.id.longSwordCardTwo);
        CardIDS[19] = R.id.longSwordCardTwo;
        CardsDrawableIDS[19] = R.drawable.six;

        cards[20] = findViewById(R.id.archerCardOne);
        CardIDS[20] = R.id.archerCardOne;
        CardsDrawableIDS[20] = R.drawable.aa;

        cards[21] = findViewById(R.id.archerCardTwo);
        CardIDS[21] = R.id.archerCardTwo;
        CardsDrawableIDS[21] = R.drawable.aa;

        cards[22] = findViewById(R.id.shieldCardOne);
        CardIDS[22] = R.id.shieldCardOne;
        CardsDrawableIDS[22] = R.drawable.ss;

        cards[23] = findViewById(R.id.shieldCardTwo);
        CardIDS[23] = R.id.shieldCardTwo;
        CardsDrawableIDS[23] = R.drawable.ss;

        cards[24] = findViewById(R.id.crownCard);
        CardIDS[24] = R.id.crownCard;
        CardsDrawableIDS[24] = R.drawable.crown;
    }

    public void onCardClick(View view) {

        for (int i = 0; i < TOTAL_CARDS; i++) {

            if (cards[i].getId() == view.getId()) {

                isCardSelected[i] = !isCardSelected[i];

                counter = (isCardSelected[i] == true ? counter + 1 : counter - 1);

                cards[i].setBackgroundColor(Color.parseColor(isCardSelected[i] == true ?
                        SELECTED_CARD_BACKGROUND : DESELECTED_CARD_BACKGROUND));
            }
        }

        checkCardCounter();
    }


    public void resetCardBackground() {

        for (int i = 0; i < TOTAL_CARDS; i++) {
            if (isCardIsAllowedToSelect[i])
                cards[i].setBackgroundColor(Color.parseColor(isCardSelected[i] == true ? SELECTED_CARD_BACKGROUND
                        : DESELECTED_CARD_BACKGROUND));
        }

    }

    public void EnableAll() {

        for (int i = 0; i < TOTAL_CARDS; i++) {
            if (isCardIsAllowedToSelect[i])
                cards[i].setEnabled(true);
        }

    }

    public void disableAllCardsClick() {

        for (int i = 0; i < TOTAL_CARDS; i++) {
            if (isCardIsAllowedToSelect[i]) {
                cards[i].setEnabled(false);
                cards[i].setBackgroundColor(Color.parseColor(isCardSelected[i] == true ? SELECTED_CARD_BACKGROUND :
                        DISABLED_CARD_BACKGROUND));
            }
        }

    }


    public void checkCardCounter() {
        if (counter == 5) {
            // disable all
            disableAllCardsClick();
            resetBtn.setEnabled(true);
            nextPileCardSelectBtn.setEnabled(true);
        }
    }

    public void onResetBtnClick(View view) {
        deSelectAllCards();
        EnableAll();
        resetCardBackground();
        nextPileCardSelectBtn.setEnabled(false);
        counter = 0;
    }

    public void OnNextPileCardSelectBtnClick(View view) {

        int selectedCardCounter = 0;
        int[] fiveSelectedCardDrawableIDS = new int[5];
        for (int i = 0; i < TOTAL_CARDS; i++) {
            if (isCardSelected[i]) {

                fiveSelectedCards[selectedCardCounter] = CardIDS[i];
                fiveSelectedCardDrawableIDS[selectedCardCounter] = CardsDrawableIDS[i];
                selectedCardCounter++;
            }
        }
        Intent goBackIntent = new Intent(this, FivePilesActivity.class);

        goBackIntent.putExtra(KEY_SELECTED_CARDS, fiveSelectedCards);
        goBackIntent.putExtra(KEY_SELECTED_CARDS_DRAWABLE_IDS, fiveSelectedCardDrawableIDS);

        setResult(getIntent().getIntExtra(KEY_REQUEST_CODE, 0), goBackIntent);
        finish();

    }
}