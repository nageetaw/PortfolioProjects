package com.example.scrimish;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.Switch;
import android.widget.Toast;

import com.google.gson.Gson;

public class SelectPersonActivity extends AppCompatActivity {

    Intent personDetailIntent;
    Button startGameBtn;
    SharedPreferences sharedPreferences;
    Gson gson;
    static String KEY_PLAYERS_DATA = "PlayersData";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_select_person);
        startGameBtn = findViewById(R.id.startGameBtn);


        gson = new Gson();
        sharedPreferences = getSharedPreferences(KEY_PLAYERS_DATA, MODE_PRIVATE);

        checkIfPlayersHaveSelectedPiles();

    }

    public void checkIfPlayersHaveSelectedPiles() {
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

            if (PlayerOne == null || PlayerTwo == null) {
                startGameBtn.setEnabled(false);
            } else {
                if (PlayerOne.getAllPilesAreSelected() && PlayerTwo.getAllPilesAreSelected()) {
                    if (PlayerOne.getDefenderOrAttacker())
                        Toast.makeText(this, "Player One is Attacker", Toast.LENGTH_LONG).show();
                    if (PlayerTwo.getDefenderOrAttacker())
                        Toast.makeText(this, "Player two is Attacker", Toast.LENGTH_LONG).show();
                    startGameBtn.setEnabled(true);
                }
            }


        } catch (Exception e) {
            Log.d("error", e.getMessage());
        }
    }

    public void onButtonClick(View view) {
        personDetailIntent = new Intent(this, PersonDetailsActivity.class);
        switch (view.getId()) {
            case R.id.playerOne:
                personDetailIntent.putExtra("player", "playerOne");
                startActivity(personDetailIntent);
                break;
            case R.id.playerTwo:
                personDetailIntent.putExtra("player", "playerTwo");
                startActivity(personDetailIntent);
                break;
        }
    }

    public void onOpenRulesBtnClick(View view) {
        Intent onOpenRulesintent = new Intent(this, gameRuleActivity.class);
        startActivity(onOpenRulesintent);
    }

    public void onStartGameBtnClick(View view) {

        Intent GameDeskActivityIntent = new Intent(this, GameDeskActivity.class);
        startActivity(GameDeskActivityIntent);
    }
}