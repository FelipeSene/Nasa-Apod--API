package com.example.planetzuc;

import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import com.bumptech.glide.Glide;

import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

public class Uranoapi extends AppCompatActivity {

    private TextView nameTextView;
    private TextView taglineTextView;
    private ImageView taglineIconImageView;


    private ImageView pictureImageView;
    private TextView descriptionTextView;
    private TextView distanceFromSunTextView;
    private TextView yearLengthTextView;
    private TextView namesakeTextView;
    private ImageView textureUrl;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.uranoapi);

        View botao;

        botao = findViewById(R.id.btvoltar);


        botao.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                Intent intent = new Intent(Uranoapi.this,buscaplaneta.class);
                startActivity(intent);
            }
        });

        nameTextView = findViewById(R.id.nameTextView);
        taglineTextView = findViewById(R.id.taglineTextView);
        taglineIconImageView = findViewById(R.id.taglineIconImageView);
        pictureImageView = findViewById(R.id.pictureImageView);
        descriptionTextView = findViewById(R.id.descriptionTextView);
        distanceFromSunTextView = findViewById(R.id.distanceFromSunTextView);
        yearLengthTextView = findViewById(R.id.yearLengthTextView);
        // namesakeTextView = findViewById(R.id.namesakeTextView);
        textureUrl = findViewById(R.id.spaceTextureImageView);

        String planetUrl = "https://localhost:7218/api/Planeta";
        FetchPlanetDataTask task = new FetchPlanetDataTask();
        task.execute(planetUrl);
    }

    private class FetchPlanetDataTask extends AsyncTask<String, Void, PlanetaDate> {

        @Override
        protected PlanetaDate doInBackground(String... urls) {
            String planetUrl = urls[0];
            String jsonResponse = "";

            try {
                URL url = new URL(planetUrl);
                HttpURLConnection connection = (HttpURLConnection) url.openConnection();
                connection.setRequestMethod("GET");

                InputStream inputStream = connection.getInputStream();
                BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(inputStream));
                String line;
                while ((line = bufferedReader.readLine()) != null) {
                    jsonResponse += line;
                }

                bufferedReader.close();
                inputStream.close();
                connection.disconnect();
                
                JSONObject jsonObject = new JSONObject(jsonResponse);
                
                String name = jsonObject.optString("name", "");
                String spaceTextureUrl = jsonObject.optString("spaceTexture_url", "");

                return new PlanetaDate(name, tagline, taglineIcon, pictureUrl, textureUrl, description, distanceFromSun, yearLength, namesake, spaceTextureUrl);
            } catch (IOException | JSONException e) {
                e.printStackTrace();
            }

             return null;
         }


        
        @Override
        protected void onPostExecute(PlanetaDate planetData) {
            if (planetData != null) {
                nameTextView.setText(planetData.getName());
                taglineTextView.setText(planetData.getTagline());
                Glide.with(Uranoapi.this)
                        .load(planetData.getTagline_icon())
                        .circleCrop()
                        .into(taglineIconImageView);

                // Configurar os campos extras
                Glide.with(Uranoapi.this)
                        .load(planetData.getPicture())
                        .into(pictureImageView);

                descriptionTextView.setText(planetData.getDescription());
                distanceFromSunTextView.setText(planetData.getDistanceFromSun());
                yearLengthTextView.setText(planetData.getYearLength());
                //   namesakeTextView.setText(planetData.getNamesake());

                Glide.with(Uranoapi.this)
                        .load(planetData.getTextureUrl())
                        .into(textureUrl);
            }
        }



    }
}
