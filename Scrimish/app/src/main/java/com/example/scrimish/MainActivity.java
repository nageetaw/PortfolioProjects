package com.example.scrimish;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.media.MediaPlayer;
import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    MediaPlayer player;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

    }

    @Override
    protected void onPause() {
        super.onPause();
        player.stop();
    }

    @Override
    protected void onResume() {
        super.onResume();
        player = MediaPlayer.create(this, R.raw.welcome);
        player.start();
    }

    public void OnLetsStartClick(View v) {
        Intent intent = new Intent(this, SelectPersonActivity.class);
        startActivity(intent);
    }
}