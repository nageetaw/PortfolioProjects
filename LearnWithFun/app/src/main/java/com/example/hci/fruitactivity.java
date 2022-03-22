package com.example.hci;

import androidx.appcompat.app.AppCompatActivity;

import android.media.MediaPlayer;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import pl.droidsonroids.gif.GifImageView;

public class fruitactivity extends AppCompatActivity {

    GifImageView fruitGifview;
    int count = 1;
    MediaPlayer mediaPlayer;
    Button backFruitBtn,nextFruitBtn;
    TextView fruitName;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_fruitactivity);
        fruitGifview = findViewById(R.id.fruitGifview);
        fruitGifview.setImageResource(R.drawable.apple);
        mediaPlayer = MediaPlayer.create(this, R.raw.apple);
        mediaPlayer.start();
        backFruitBtn= findViewById(R.id.backFruitBtn);
        backFruitBtn.setEnabled(false);
        nextFruitBtn= findViewById(R.id.nextFruitBtn);
        fruitName= findViewById(R.id.name);
        fruitName.setText("Apple");

    }
    public void backClick(View view) {
        count--;
        switch (count) {
            case 1:
                fruitGifview.setImageResource(R.drawable.apple);
                mediaPlayer = MediaPlayer.create(this, R.raw.apple);
                mediaPlayer.start();
                backFruitBtn.setEnabled(false);
                fruitName.setText("Apple");
                break;
            case 2:
                fruitGifview.setImageResource(R.drawable.orange);
                mediaPlayer = MediaPlayer.create(this, R.raw.orange);
                mediaPlayer.start();
                backFruitBtn.setEnabled(true);
                fruitName.setText("Orange");
                break;
            case 3:
                fruitGifview.setImageResource(R.drawable.strawberry);
                mediaPlayer = MediaPlayer.create(this, R.raw.strawberry);
                mediaPlayer.start();
                fruitName.setText("Strawberry");
                break;
            case 4:

                fruitGifview.setImageResource(R.drawable.grapes);
                mediaPlayer = MediaPlayer.create(this, R.raw.grape);
                mediaPlayer.start();
                nextFruitBtn.setEnabled(true);
                fruitName.setText("Grapes");
                break;
            case 5:
                fruitGifview.setImageResource(R.drawable.watermelon);
                mediaPlayer = MediaPlayer.create(this, R.raw.watermelon);
                mediaPlayer.start();
                nextFruitBtn.setEnabled(false);
                fruitName.setText("Watermelon");
                break;

        }

    }
    public void nextClick(View view) {
        count++;
        switch (count) {
            case 1:
                fruitGifview.setImageResource(R.drawable.apple);
                mediaPlayer = MediaPlayer.create(this, R.raw.apple);
                mediaPlayer.start();
                backFruitBtn.setEnabled(false);
                fruitName.setText("Apple");
                break;
            case 2:
                fruitGifview.setImageResource(R.drawable.orange);
                mediaPlayer = MediaPlayer.create(this, R.raw.orange);
                mediaPlayer.start();
                backFruitBtn.setEnabled(true);
                fruitName.setText("Orange");
                break;
            case 3:
                fruitGifview.setImageResource(R.drawable.strawberry);
                mediaPlayer = MediaPlayer.create(this, R.raw.strawberry);
                mediaPlayer.start();
                fruitName.setText("Strawberry");
                break;
            case 4:
                fruitGifview.setImageResource(R.drawable.grapes);
                mediaPlayer = MediaPlayer.create(this, R.raw.grape);
                mediaPlayer.start();
                nextFruitBtn.setEnabled(true);
                fruitName.setText("Grapes");
                break;
            case 5:
                fruitGifview.setImageResource(R.drawable.watermelon);
                mediaPlayer = MediaPlayer.create(this, R.raw.watermelon);
                mediaPlayer.start();
                nextFruitBtn.setEnabled(false);
                fruitName.setText("Watermelon");
                break;

        }

    }
    public void GoToHome(View view){
        finish();

    }
}