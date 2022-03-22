package com.example.hci;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.speech.tts.TextToSpeech;
import android.view.Menu;
import android.view.View;
import android.widget.TextView;

public class SelectMediumScreen extends AppCompatActivity {

    TextView userNameValue, categoryMessage;
    char[] nameCharachters;
    boolean isSpeakerReady = false;
    TextToSpeech textToSpeech;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_select_medium_screen);
        Intent intent = getIntent();
        userNameValue = findViewById(R.id.userNameValue);
        categoryMessage = findViewById(R.id.categoryMessage);

        nameCharachters = ("Hello " + intent.getStringExtra("userName")).toCharArray();

        Thread nameThread = new Thread(new Runnable() {
            @Override
            public void run() {
                String tempText = "";
                for (int i = 0; i < nameCharachters.length; i++) {
                    tempText += nameCharachters[i];
                    String finalTempText = tempText;
                    userNameValue.post(new Runnable() {
                        @Override
                        public void run() {
                            userNameValue.setText(finalTempText);
                        }
                    });
                    try {
                        Thread.sleep(200);
                    } catch (InterruptedException e) {
                        e.printStackTrace();
                    }
                }

            }
        });
        nameThread.start();

        textToSpeech = new TextToSpeech(this,
                new TextToSpeech.OnInitListener() {
                    @Override
                    public void onInit(int status) {
                        // code to run when done loading

                        textToSpeech.speak("Hello " + intent.getStringExtra("userName") + " Please Select What you want to Learn", TextToSpeech.QUEUE_FLUSH, null);

                    }
                });

        categoryMessage.setText("\n Select What you want to Learn");
    }

    public void animalSelectClick(View view) {
        Intent intent = new Intent(this, AnimalsActivity.class);
        startActivity(intent);
    }



    public void numberSelectClick(View v) {
        Intent intent = new Intent(this, Numbers.class);
        startActivity(intent);
    }
    public void numberFruitsClick(View v) {
        Intent intent = new Intent(this, fruitactivity.class);
        startActivity(intent);
    }
    public void VegetablesClick(View view){
        Intent intent = new Intent(this,  stationaryScreen.class);
        startActivity(intent);
    }
}