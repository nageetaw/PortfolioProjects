package com.example.hci;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.media.MediaPlayer;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import java.io.IOException;
import java.io.InputStream;

public class MainActivity extends AppCompatActivity {
    MediaPlayer themeSong;
    int length;
    TextView gameName;
    char[] gameNameCharacters = {'L', 'E', 'T', '\'', 'S', '\n','R','E','M','E','M','B','E','R'};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        themeSong = MediaPlayer.create(this, R.raw.welcomesong);
        themeSong.start();
        gameName = findViewById(R.id.gameName);

        Thread nameThread = new Thread(new Runnable() {
            @Override
            public void run() {
                String tempText="";
                for (int i = 0; i < gameNameCharacters.length; i++) {
                    tempText+=gameNameCharacters[i];
                    String finalTempText = tempText;
                    gameName.post(new Runnable() {
                        @Override
                        public void run() {
                            gameName.setText(finalTempText);
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
    }

    @Override
    protected void onPause() {
        super.onPause();
        themeSong.pause();
        length = themeSong.getCurrentPosition();
    }

    public void startInBtnClick(View v) {
        Intent intent = new Intent(this, MainScreen.class);
        startActivity(intent);
    }

    @Override
    protected void onResume() {
        super.onResume();
        themeSong.seekTo(length);
        themeSong.start();
    }
}