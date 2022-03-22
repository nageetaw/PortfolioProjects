package com.example.scrimish;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.CompoundButton;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

import com.google.gson.Gson;

public class PersonDetailsActivity extends AppCompatActivity {

    boolean currentPlayerExists;
    Intent selectPersonIntent;
    TextView personIdentifier;
    Intent selectPilesIntent;
    TextView personName;
    SharedPreferences sharedPreferences;
    Player player;
    String PLAYER_NUMBER;
    static String KEY_PLAYERS_DATA = "PlayersData", KEY_PLAYER_NAME = "playerName", KEY_PLAYER_NUMBER = "playerNumber";
    RadioButton male, female;
    RadioGroup genderGroup;

    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_person_details);
        selectPersonIntent = getIntent();


        personIdentifier = findViewById(R.id.personIdentifier);
        PLAYER_NUMBER = selectPersonIntent.getStringExtra("player");
        personIdentifier.setText(PLAYER_NUMBER);
        personName = findViewById(R.id.personName);
        male = findViewById(R.id.maleBtn);
        female = findViewById(R.id.femaleBtn);
        male.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                if (isChecked)
                    male.setSelected(true);
            }
        });

        female.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                if (isChecked)
                    female.setSelected(true);
            }
        });

        currentPlayerExists = false;

        // check if current person has already selected cards
        checkIfPlayerHasAlreadyCreated();


    }

    public void checkIfPlayerHasAlreadyCreated() {
        try {
            sharedPreferences = getSharedPreferences(KEY_PLAYERS_DATA, MODE_PRIVATE);
            Gson gson = new Gson();
            String json = sharedPreferences.getString(PLAYER_NUMBER, "");//VALUE_PLAYER_NUMBER=playerOne
            player = gson.fromJson(json, Player.class);
            if (player.getPlayerNo() != 0) {
                Toast.makeText(this, "player number is " + player.getPlayerNo(), Toast.LENGTH_LONG).show();
                currentPlayerExists = true;
                personName.setText(player.getPlayerName());
                personName.setEnabled(false);

                if (player.getGender()) {
                    female.setChecked(true);
                } else {
                    male.setChecked(true);
                }
                male.setEnabled(false);
                female.setEnabled(false);
            }
        } catch (Exception e) {
            Log.d("error", e.getMessage());
        }
    }


    public void onNextClick(View v) {

        boolean genderIsSelected = male.isSelected() || female.isSelected();

        if (personName.getText().toString().length() == 0 || !genderIsSelected) {

            Toast.makeText(this, "Please Select all details", Toast.LENGTH_LONG).show();
        } else {
            selectPilesIntent = new Intent(this, FivePilesActivity.class);
            selectPilesIntent.putExtra(KEY_PLAYER_NUMBER, PLAYER_NUMBER);

            // preferences
            if (!currentPlayerExists) {

                selectPilesIntent.putExtra(KEY_PLAYER_NAME, personName.getText().toString());
                sharedPreferences = getSharedPreferences(KEY_PLAYERS_DATA, MODE_PRIVATE);
                player = new Player();
                player.setPlayerName(personName.getText().toString());
                // check for male or female

                if (male.isSelected()) {
                    Log.d("gender----male", "" + (male.isSelected() ? "true" : "false"));
                    player.setGender(false);
                } else if (female.isSelected()) {
                    Log.d("gender----female", "" + (female.isSelected() ? "true" : "false"));
                    player.setGender(true);
                }
                Log.d("gender----", "" + (player.getGender() ? "true" : "false"));

                // for temp use
                player.setPlayerNo(PLAYER_NUMBER.equals("playerOne") ? 1 : 2);
                Log.d(KEY_PLAYER_NUMBER, PLAYER_NUMBER);

                SharedPreferences.Editor editor = sharedPreferences.edit();
                Gson gson = new Gson();
                String json = gson.toJson(player);
                editor.putString(PLAYER_NUMBER, json);
                editor.commit();
            } else {
                selectPilesIntent.putExtra(KEY_PLAYER_NAME, player.getPlayerName());
            }

            startActivity(selectPilesIntent);
        }
    }
}