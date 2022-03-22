package com.example.scrimish;

import android.content.Context;
import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.provider.ContactsContract;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.HashMap;
import java.util.Map;

public class showCardsFragment extends Fragment {

    GameDeskActivity context;
    int attackerPlayer;
    String attackerPlayerName, defenderPlayerName;
    static int PLAYER_ONE_ATTACKER_KEY = 1, PLAYER_TWO_ATTACKER_KEY = 2;
    Thread playerOneThread, playerTwoThread;
    Map<String, Integer> cardsPriority;
    int resultsOfComaprison;

    showCardsFragment(Context context, int attackerPlayer, String attackerPlayerName, String defenderPlayerName) {
        this.context = (GameDeskActivity) context;
        this.attackerPlayer = attackerPlayer;
        this.attackerPlayerName = attackerPlayerName;
        this.defenderPlayerName = defenderPlayerName;
    }

    View view;
    int playerOneCardDrawableId, playerTwoCardDrawableId;
    ImageView playerOneDefendedCard, playerTwoDefendedCard, playerOneDiscardedCard, playerTwoDiscardedCard;
    TextView playerOneTotalDiscardedCards, playerTwoTotalDiscardedCards, results;

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

    }


    public int CompareCards(int attackerCardResourseId, int defenderCardResourseId) {

        String attackerCardKey = getResources().getResourceEntryName(attackerCardResourseId);
        String defenderCardKey = getResources().getResourceEntryName(defenderCardResourseId);

        int attackerCardPriority = cardsPriority.get(attackerCardKey);
        int defenderCardPriority = cardsPriority.get(defenderCardKey);


        if (attackerCardKey.equals(Constants.ARCHER_CARD_KEY) && defenderCardKey.equals(Constants.SHIELD_CARD_KEY)) {
            // both returns to same pile
            Log.d("results", "a");
            results.setText("Both cards returns to pile");
            return Constants.BOTH_CARDS_RETURNS_TO_PILE;

        } else if (attackerCardKey.equals(Constants.CROWN_CARD_KEY) && defenderCardKey.equals(Constants.CROWN_CARD_KEY)) {
            // attacker wins the game
            Log.d("results", "b");
            results.setText(attackerPlayerName + " Wins");
            return Constants.ATTACKER_WINS_THE_GAME;

        } else if (attackerCardKey.equals(Constants.CROWN_CARD_KEY) && !defenderCardKey.equals(Constants.CROWN_CARD_KEY)) {
            // defender wins the game
            Log.d("results", "c");
            results.setText(defenderPlayerName + " wins the game");
            return Constants.DEFENDER_WINS_THE_GAME;

        } else if (defenderCardKey.equals(Constants.CROWN_CARD_KEY)) {
            // attacker wins the game
            Log.d("results", "d");
            results.setText(attackerPlayerName + " wins the game");
            return Constants.ATTACKER_WINS_THE_GAME;

        } else if (attackerCardKey.equals(Constants.ARCHER_CARD_KEY) && !defenderCardKey.equals(Constants.ARCHER_CARD_KEY)) {
            // attacker wins
            Log.d("results", "e");
            results.setText(attackerPlayerName + " wins the round");
            return Constants.ATTACKER_WINS_THE_ROUND;

        } else if (defenderCardKey.equals(Constants.SHIELD_CARD_KEY)) {
            // when oponent attacks with a shield card
            // both are discarded
            Log.d("results", "f");
            results.setText("Both cards are discarded");
            return Constants.BOTH_CARDS_ARE_DISCARDED;
        } else {
            // conditions

            if (attackerCardPriority > defenderCardPriority) {
                // attacker wins
                Log.d("results", "g");
                results.setText(attackerPlayerName + " wins the round");
                return Constants.ATTACKER_WINS_THE_ROUND;

            } else if (attackerCardPriority < defenderCardPriority) {
                // defender wins
                Log.d("results", "h");
                results.setText(defenderPlayerName + " wins the round");
                return Constants.DEFENDER_WINS_THE_ROUND;

            } else {
                // both are same, hence discarded
                Log.d("results", "i");
                results.setText("Both cards are discarded");
                return Constants.BOTH_CARDS_ARE_DISCARDED;

            }
        }

    }

    public int setPlayerOneDefendedCard(int id) {
        playerOneDefendedCard.setImageResource(id);
        playerOneCardDrawableId = id;
        if (attackerPlayer != PLAYER_ONE_ATTACKER_KEY) {
            resultsOfComaprison = CompareCards(playerTwoCardDrawableId, playerOneCardDrawableId);
            context.sendResultsToPlayerTwo(resultsOfComaprison);
        } else {
            // you are a attacker
            context.playerTwoCanDefendNow();
        }
        // attacker needs to wait
        return resultsOfComaprison;

    }

    public int setPlayerTwoDefendedCard(int id) {
        playerTwoDefendedCard.setImageResource(id);
        playerTwoCardDrawableId = id;
        if (attackerPlayer != PLAYER_TWO_ATTACKER_KEY) {
            resultsOfComaprison = CompareCards(playerOneCardDrawableId, playerTwoCardDrawableId);
            context.sendResultsToPlayerOne(resultsOfComaprison);
        } else {
            // you are a attacker
            context.playerOneCanDefendNow();
        }
        return resultsOfComaprison;
    }


    public void setPlayerOneDiscardedCard() {
        int current = Integer.parseInt(playerOneTotalDiscardedCards.getText().toString());
        playerOneTotalDiscardedCards.setText("" + (current + 1));
    }

    public void setPlayerTwoDiscardedCard() {
        int current = Integer.parseInt(playerTwoTotalDiscardedCards.getText().toString());
        playerTwoTotalDiscardedCards.setText("" + (current + 1));
    }

    public void initializeAll() {
        playerOneCardDrawableId = -1;
        playerTwoCardDrawableId = -1;
        playerOneDefendedCard = view.findViewById(R.id.playerOnDefendedCard);
        playerTwoDefendedCard = view.findViewById(R.id.playerTwoDefendedCard);
        playerOneTotalDiscardedCards = view.findViewById(R.id.playerOneTotalDiscardedCards);
        playerTwoTotalDiscardedCards = view.findViewById(R.id.playerTwoTotalDiscardedCards);
        playerOneDiscardedCard = view.findViewById(R.id.playerOneDiscardedCards);
        playerTwoDiscardedCard = view.findViewById(R.id.playerTwoDiscardedCards);
        results = view.findViewById(R.id.results);
        resultsOfComaprison = -1;// -1 indicated wait

        cardsPriority = new HashMap<String, Integer>();
        // priorty of each card according to defending and attacking
        cardsPriority.put("one", 1);
        cardsPriority.put("two", 2);
        cardsPriority.put("three", 3);
        cardsPriority.put("four", 4);
        cardsPriority.put("five", 5);
        cardsPriority.put("six", 6);
        // Special Cards
        // archer card
        cardsPriority.put(Constants.ARCHER_CARD_KEY, 7);
        // shield card
        cardsPriority.put(Constants.SHIELD_CARD_KEY, 0);
        // crown card
        cardsPriority.put(Constants.CROWN_CARD_KEY, 8);


    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        view = inflater.inflate(R.layout.fragment_show_cards, container, false);

        initializeAll();
        return view;
    }
}