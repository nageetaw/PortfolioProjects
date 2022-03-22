package com.example.hci;

import androidx.appcompat.app.AppCompatActivity;

import android.media.MediaPlayer;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import pl.droidsonroids.gif.GifImageView;

public class AnimalsActivity extends AppCompatActivity {
    int count = 0;
    GifImageView animalGifview;
    MediaPlayer mediaPlayer;
    MediaPlayer soundPlayer;
    Button backAnimalBtn, nextAnimalBtn;
    TextView animalName;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_animals);
        animalGifview = findViewById(R.id.animalGifview);
        animalGifview.setImageResource(R.drawable.cat);
        backAnimalBtn = findViewById(R.id.backAnimalBtn);
        backAnimalBtn.setEnabled(false);
        mediaPlayer = MediaPlayer.create(this, R.raw.catp);
        mediaPlayer.start();
        nextAnimalBtn = findViewById(R.id.nextAnimalBtn);
        animalName = findViewById(R.id.name);
        animalName.setText("Cat");
        soundPlayer=null;
    }

    public void nextAnimalClick(View view) {
        if (soundPlayer != null) {
            soundPlayer.stop();
            soundPlayer.release();
            soundPlayer = null;
        }
        count++;
        switch (count) {
            case 0:
                animalGifview.setImageResource(R.drawable.cat);
                mediaPlayer = MediaPlayer.create(this, R.raw.catp);
                mediaPlayer.start();
                backAnimalBtn.setEnabled(false);
                animalName.setText("Cat");
                break;
            case 1:
                animalGifview.setImageResource(R.drawable.dog);
                mediaPlayer = MediaPlayer.create(this, R.raw.dogp);
                mediaPlayer.start();
                backAnimalBtn.setEnabled(true);
                animalName.setText("Dog");
                break;
            case 2:
                animalGifview.setImageResource(R.drawable.deer);
                mediaPlayer = MediaPlayer.create(this, R.raw.deerp);
                mediaPlayer.start();
                animalName.setText("Deer");
                break;
            case 3:
                animalGifview.setImageResource(R.drawable.rat);
                mediaPlayer = MediaPlayer.create(this, R.raw.mousep);
                mediaPlayer.start();
                animalName.setText("Rat");
                break;
            case 4:
                animalGifview.setImageResource(R.drawable.tigger);
                mediaPlayer = MediaPlayer.create(this, R.raw.tigerp);
                mediaPlayer.start();
                animalName.setText("Tigger");
                break;
            case 5:
                animalGifview.setImageResource(R.drawable.bear);
                mediaPlayer = MediaPlayer.create(this, R.raw.beerp);
                mediaPlayer.start();
                animalName.setText("Bear");
                nextAnimalBtn.setEnabled(true);
                break;
            case 6:
                animalGifview.setImageResource(R.drawable.rabbit);
                mediaPlayer = MediaPlayer.create(this, R.raw.rabbitp);
                mediaPlayer.start();
                nextAnimalBtn.setEnabled(false);
                animalName.setText("Rabbit");
                break;
        }
    }


    public void backAnimalClick(View view) {
        if (soundPlayer != null) {
            soundPlayer.stop();
            soundPlayer.release();
            soundPlayer = null;
        }
        count--;
        switch (count) {
            case 0:
                animalGifview.setImageResource(R.drawable.cat);
                mediaPlayer = MediaPlayer.create(this, R.raw.catp);
                mediaPlayer.start();
                backAnimalBtn.setEnabled(false);
                animalName.setText("Cat");
                break;
            case 1:
                animalGifview.setImageResource(R.drawable.dog);
                mediaPlayer = MediaPlayer.create(this, R.raw.dogp);
                mediaPlayer.start();
                backAnimalBtn.setEnabled(true);
                animalName.setText("Dog");
                break;
            case 2:
                animalGifview.setImageResource(R.drawable.deer);
                mediaPlayer = MediaPlayer.create(this, R.raw.deerp);
                mediaPlayer.start();
                animalName.setText("Deer");
                break;
            case 3:
                animalGifview.setImageResource(R.drawable.rat);
                mediaPlayer = MediaPlayer.create(this, R.raw.mousep);
                mediaPlayer.start();
                animalName.setText("Rat");

                break;
            case 4:
                animalGifview.setImageResource(R.drawable.tigger);
                mediaPlayer = MediaPlayer.create(this, R.raw.tigerp);
                mediaPlayer.start();
                animalName.setText("Tigger");
                break;
            case 5:
                animalGifview.setImageResource(R.drawable.bear);
                mediaPlayer = MediaPlayer.create(this, R.raw.beerp);
                mediaPlayer.start();
                animalName.setText("Bear");
                nextAnimalBtn.setEnabled(true);
                break;
            case 6:
                animalGifview.setImageResource(R.drawable.rabbit);
                mediaPlayer = MediaPlayer.create(this, R.raw.rabbitp);
                mediaPlayer.start();
                animalName.setText("Rabbit");
                nextAnimalBtn.setEnabled(false);
                break;
        }
    }

    public void playSoundClick(View view) {
        if (soundPlayer != null) {
            soundPlayer.stop();
            soundPlayer.release();
            soundPlayer = null;
        }
        switch (count) {
            case 0:

                soundPlayer = MediaPlayer.create(this, R.raw.cat);
                soundPlayer.start();

                break;
            case 1:

                soundPlayer = MediaPlayer.create(this, R.raw.dog);
                soundPlayer.start();

                break;
            case 2:

                soundPlayer = MediaPlayer.create(this, R.raw.deer);
                soundPlayer.start();

                break;
            case 3:

                soundPlayer = MediaPlayer.create(this, R.raw.mouse);
                soundPlayer.start();

                break;
            case 4:

                soundPlayer = MediaPlayer.create(this, R.raw.tigger);
                soundPlayer.start();

                break;
            case 5:

                soundPlayer = MediaPlayer.create(this, R.raw.bear);
                soundPlayer.start();

                break;
            case 6:

                soundPlayer = MediaPlayer.create(this, R.raw.rabbit);
                soundPlayer.start();

                break;
        }
    }
    public void GoToHome(View view){
        finish();
    }
}