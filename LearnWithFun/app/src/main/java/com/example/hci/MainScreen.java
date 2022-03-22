package com.example.hci;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.speech.tts.TextToSpeech;
import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import com.google.android.material.textfield.TextInputEditText;
import com.google.android.material.textfield.TextInputLayout;

public class MainScreen extends AppCompatActivity {

   TextInputLayout nameField;
   TextToSpeech textToSpeech;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_screen);
      nameField= findViewById(R.id.userName);

        textToSpeech = new TextToSpeech(this,
                new TextToSpeech.OnInitListener() {
                    @Override
                    public void onInit(int status) {
                        // code to run when done loading

                        textToSpeech.speak("Welcome Please Enter your good Name" , TextToSpeech.QUEUE_FLUSH, null);

                    }
                });

    }
    public void NextBtnClick(View v){
        Log.d("name",""+nameField.getEditText().toString().length());
       if (nameField.getEditText().toString().length()  == 0){
           Toast.makeText(this, "Please enter your name", Toast.LENGTH_SHORT).show();
       }else {
           Intent intent = new Intent(this, SelectMediumScreen.class);
           intent.putExtra("userName", nameField.getEditText().getText().toString());
           startActivity(intent);
       }
    }
}