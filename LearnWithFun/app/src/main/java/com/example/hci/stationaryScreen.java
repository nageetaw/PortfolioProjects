package com.example.hci;

import androidx.appcompat.app.AppCompatActivity;

import android.media.MediaPlayer;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import pl.droidsonroids.gif.GifImageView;

public class stationaryScreen extends AppCompatActivity {
    MediaPlayer mediaPlayer;
    GifImageView gifImageView;
    Button backStatBtn, nextStatBtn;
    TextView StateName;
    int count;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_stationary_screen);

        mediaPlayer = MediaPlayer.create(this, R.raw.pen);
        mediaPlayer.start();

        count = 0;
        backStatBtn = findViewById(R.id.backStatBtn);
        nextStatBtn = findViewById(R.id.nextStatBtn);
        StateName = findViewById(R.id.name);
        gifImageView = findViewById(R.id.statGifview);
        StateName.setText("Pen");
        backStatBtn.setEnabled(false);

    }

    public void nextClick(View v) {
        ++count;
        switch (count) {
            case 0:
                backStatBtn.setEnabled(false);
                gifImageView.setImageResource(R.drawable.pen);
                mediaPlayer = MediaPlayer.create(this, R.raw.pen);
                mediaPlayer.start();
                StateName.setText("Pen");
                break;
            case 1:
                backStatBtn.setEnabled(true);
                gifImageView.setImageResource(R.drawable.pencil);
                mediaPlayer = MediaPlayer.create(this, R.raw.pencil);
                mediaPlayer.start();
                StateName.setText("Pencil");

                break;
            case 2:
                gifImageView.setImageResource(R.drawable.book);
                mediaPlayer = MediaPlayer.create(this, R.raw.book);
                mediaPlayer.start();
                StateName.setText("Book");
                break;
            case 3:
                gifImageView.setImageResource(R.drawable.eraser);
                mediaPlayer = MediaPlayer.create(this, R.raw.eraser);
                mediaPlayer.start();
                StateName.setText("Eraser");
                nextStatBtn.setEnabled(true);
                break;
            case 4:
                gifImageView.setImageResource(R.drawable.notebook);
                mediaPlayer = MediaPlayer.create(this, R.raw.notebook);
                mediaPlayer.start();
                StateName.setText("NoteBook");
                nextStatBtn.setEnabled(false);
                break;


        }
    }

    public void backClick(View v) {
        count--;
        switch (count) {
            case 0:
                backStatBtn.setEnabled(false);
                gifImageView.setImageResource(R.drawable.pen);
                mediaPlayer = MediaPlayer.create(this, R.raw.pen);
                mediaPlayer.start();
                StateName.setText("Pen");

                break;
            case 1:
                backStatBtn.setEnabled(true);
                gifImageView.setImageResource(R.drawable.pencil);
                mediaPlayer = MediaPlayer.create(this, R.raw.pencil);
                mediaPlayer.start();
                StateName.setText("Pencil");
                break;
            case 2:
                gifImageView.setImageResource(R.drawable.book);
                mediaPlayer = MediaPlayer.create(this, R.raw.book);
                mediaPlayer.start();
                StateName.setText("Book");
                break;
            case 3:
                gifImageView.setImageResource(R.drawable.eraser);
                mediaPlayer = MediaPlayer.create(this, R.raw.eraser);
                mediaPlayer.start();
                StateName.setText("Eraser");
                nextStatBtn.setEnabled(true);
                break;
            case 4:
                gifImageView.setImageResource(R.drawable.notebook);
                mediaPlayer = MediaPlayer.create(this, R.raw.notebook);
                mediaPlayer.start();
                StateName.setText("NoteBook");
                nextStatBtn.setEnabled(false);
                break;


        }
    }
    public  void  GoToHome(View view){
        finish();
    }
}