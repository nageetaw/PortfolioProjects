package com.example.hci;

import androidx.appcompat.app.AppCompatActivity;

import android.media.MediaPlayer;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import pl.droidsonroids.gif.GifImageView;

public class Numbers extends AppCompatActivity {
    GifImageView gifImageView;
    MediaPlayer soundPlayer;
    Button backNumberaBtn, nextNumberaBtn;
    TextView numberName;
    int count;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_numbers);
        gifImageView = findViewById(R.id.numberGifview);
        backNumberaBtn = findViewById(R.id.backNumberaBtn);
        backNumberaBtn.setEnabled(false);
        count = 0;

        gifImageView.setImageResource(R.drawable.zero);
        soundPlayer = MediaPlayer.create(this, R.raw.zero);
        soundPlayer.start();
        nextNumberaBtn = findViewById(R.id.nextNumberaBtn);
        numberName = findViewById(R.id.name);
        numberName.setText("Zero");
    }

    public void nextClick(View v) {
        ++count;
        switch (count) {
            case 0:
                backNumberaBtn.setEnabled(false);
                gifImageView.setImageResource(R.drawable.zero);
                soundPlayer = MediaPlayer.create(this, R.raw.zero);
                soundPlayer.start();
                numberName.setText("Zero");
                break;
            case 1:
                backNumberaBtn.setEnabled(true);
                gifImageView.setImageResource(R.drawable.one);
                soundPlayer = MediaPlayer.create(this, R.raw.one);
                soundPlayer.start();
                numberName.setText("One");

                break;
            case 2:
                gifImageView.setImageResource(R.drawable.two);
                soundPlayer = MediaPlayer.create(this, R.raw.two);
                soundPlayer.start();
                numberName.setText("Two");
                break;
            case 3:
                gifImageView.setImageResource(R.drawable.three);
                soundPlayer = MediaPlayer.create(this, R.raw.three);
                soundPlayer.start();
                numberName.setText("Three");
                break;
            case 4:
                gifImageView.setImageResource(R.drawable.four);
                soundPlayer = MediaPlayer.create(this, R.raw.four);
                soundPlayer.start();
                numberName.setText("Four");
                break;
            case 5:
                gifImageView.setImageResource(R.drawable.five);
                soundPlayer = MediaPlayer.create(this, R.raw.five);
                soundPlayer.start();
                numberName.setText("Five");
                break;
            case 6:
                gifImageView.setImageResource(R.drawable.six);
                soundPlayer = MediaPlayer.create(this, R.raw.six);
                soundPlayer.start();
                numberName.setText("Six");

                break;
            case 7:
                gifImageView.setImageResource(R.drawable.seven);
                soundPlayer = MediaPlayer.create(this, R.raw.seven);
                soundPlayer.start();
                numberName.setText("Seven");
                break;
            case 8:
                gifImageView.setImageResource(R.drawable.eight);
                soundPlayer = MediaPlayer.create(this, R.raw.eight);
                soundPlayer.start();
                nextNumberaBtn.setEnabled(true);
                numberName.setText("Eight");
                break;
            case 9:
                gifImageView.setImageResource(R.drawable.nine);
                soundPlayer = MediaPlayer.create(this, R.raw.nine);
                soundPlayer.start();
                nextNumberaBtn.setEnabled(false);
                numberName.setText("Nine");
                break;

        }
    }

    public void backClick(View v) {
        count--;
        switch (count) {
            case 0:
                gifImageView.setImageResource(R.drawable.zero);
                soundPlayer = MediaPlayer.create(this, R.raw.zero);
                soundPlayer.start();
                backNumberaBtn.setEnabled(false);
                numberName.setText("Zero");
                break;
            case 1:

                gifImageView.setImageResource(R.drawable.one);
                soundPlayer = MediaPlayer.create(this, R.raw.one);
                soundPlayer.start();
                numberName.setText("One");
                break;
            case 2:
                gifImageView.setImageResource(R.drawable.two);
                soundPlayer = MediaPlayer.create(this, R.raw.two);
                soundPlayer.start();
                numberName.setText("Two");
                break;
            case 3:
                gifImageView.setImageResource(R.drawable.three);
                soundPlayer = MediaPlayer.create(this, R.raw.three);
                soundPlayer.start();
                numberName.setText("Three");
                break;
            case 4:
                gifImageView.setImageResource(R.drawable.four);
                soundPlayer = MediaPlayer.create(this, R.raw.four);
                soundPlayer.start();
                numberName.setText("Four");
                break;
            case 5:
                gifImageView.setImageResource(R.drawable.five);
                soundPlayer = MediaPlayer.create(this, R.raw.five);
                soundPlayer.start();
                numberName.setText("Five");
                break;
            case 6:
                gifImageView.setImageResource(R.drawable.six);
                soundPlayer = MediaPlayer.create(this, R.raw.six);
                soundPlayer.start();
                numberName.setText("Six");
                break;
            case 7:
                gifImageView.setImageResource(R.drawable.seven);
                soundPlayer = MediaPlayer.create(this, R.raw.seven);
                soundPlayer.start();
                numberName.setText("Seven");
                break;
            case 8:
                gifImageView.setImageResource(R.drawable.eight);
                soundPlayer = MediaPlayer.create(this, R.raw.eight);
                soundPlayer.start();
                numberName.setText("Eight");
                nextNumberaBtn.setEnabled(true);
                break;
            case 9:
                gifImageView.setImageResource(R.drawable.nine);
                soundPlayer = MediaPlayer.create(this, R.raw.nine);
                soundPlayer.start();
                numberName.setText("Nine");
                nextNumberaBtn.setEnabled(false);
                break;

        }
    }
    public void GoToHome(View view){
        finish();
    }
}