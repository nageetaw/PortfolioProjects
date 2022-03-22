package com.example.scrimish;

import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.FragmentTransaction;

import android.content.SharedPreferences;
import android.os.Bundle;
import android.util.Log;
import android.widget.Toast;

import com.google.gson.Gson;

public class GameDeskActivity extends AppCompatActivity {
    FragmentTransaction fragmentTransaction;
    PersonOneSideFragment personOneSideFragment;
    PersonTwoSideFragment personTwoSideFragment;
    showCardsFragment showcardsFragment;

    Player playerOne, playerTwo;

    SharedPreferences sharedPreferences;
    Gson gson;
    static String KEY_PLAYERS_DATA = "PlayersData", KEY_PLAYER_ONE = "playerOne", KEY_PLAYER_TWO = "playerTwo";
    boolean isPlayerFetechedSuccessfull;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_game_desk);

        isPlayerFetechedSuccessfull = false;
        getPlayer();
        try {
            if (isPlayerFetechedSuccessfull) {

                //attackerPlayer Key: 1 for player One , 2 for Player 2
                int attackerPlayer = (playerOne.getDefenderOrAttacker() ? 1 : 2);
                String attackerPlayerName = (playerOne.getDefenderOrAttacker() ? playerOne.getPlayerName() : playerTwo.getPlayerName());
                String defenderPlayerName = (playerOne.getDefenderOrAttacker() ? playerTwo.getPlayerName() : playerOne.getPlayerName());
                personOneSideFragment = new PersonOneSideFragment(this, playerOne);
                personTwoSideFragment = new PersonTwoSideFragment(this, playerTwo);
                showcardsFragment = new showCardsFragment(this, attackerPlayer, attackerPlayerName, defenderPlayerName);

                fragmentTransaction = getSupportFragmentManager().beginTransaction();

                fragmentTransaction.add(R.id.person_one_side, personOneSideFragment);
                fragmentTransaction.add(R.id.person_two_side, personTwoSideFragment);
                fragmentTransaction.add(R.id.showCardFragment, showcardsFragment);

                fragmentTransaction.commit();
            } else {
                Toast.makeText(this, "Some internal issue occurs", Toast.LENGTH_LONG).show();
            }
        } catch (Exception e) {
            Log.d("error", e.getMessage());
        }
    }


    public void getPlayer() {
        try {
            sharedPreferences = getSharedPreferences(KEY_PLAYERS_DATA, MODE_PRIVATE);
            gson = new Gson();
            String playerOneData = sharedPreferences.getString(KEY_PLAYER_ONE, "");
            String playerTwoData = sharedPreferences.getString(KEY_PLAYER_TWO, "");
            playerOne = gson.fromJson(playerOneData, Player.class);
            playerTwo = gson.fromJson(playerTwoData, Player.class);
            isPlayerFetechedSuccessfull = true;
        } catch (Exception e) {
            Log.d("error", e.getMessage());
        }

    }

    public int setPlayerOneDefendedCard(int id) {
        return showcardsFragment.setPlayerOneDefendedCard(id);

    }

    public void setPlayerOneDiscardedCard() {
        showcardsFragment.setPlayerOneDiscardedCard();
    }

    public int setPlayerTwoDefendedCard(int id) {
        return showcardsFragment.setPlayerTwoDefendedCard(id);

    }

    public void setPlayerTwoDiscardedCard() {
        showcardsFragment.setPlayerTwoDiscardedCard();
    }

    public void sendResultsToPlayerOne(int resultValueCode) {
        Toast.makeText(this, "" + resultValueCode, Toast.LENGTH_LONG).show();
        personOneSideFragment.performResultsAnalysis(resultValueCode);
    }

    public void sendResultsToPlayerTwo(int resultValueCode) {
        Toast.makeText(this, "" + resultValueCode, Toast.LENGTH_LONG).show();
        personTwoSideFragment.performResultAnalysis(resultValueCode);
    }

    public void playerOneCanDefendNow() {
        personOneSideFragment.performYourTurn();
    }

    public void playerTwoCanDefendNow() {
        personTwoSideFragment.performYourTurn();
    }
}

/**
 * If you are defender you will get the results, else you need to fetch the results
 */