package com.example.planetzuc;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;


import androidx.appcompat.app.AppCompatActivity;

public class Usuario extends AppCompatActivity implements View.OnClickListener {

    // declare the variables
    Button read, write;
    EditText userInput;
    TextView fileContent;

    private String filename = "demoFile.txt";
    View botao, botao2, botao4, botao5;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.usuario);

        read = findViewById(R.id.read_button);
        write = findViewById(R.id.write_button);
        userInput = findViewById(R.id.userInput);
        fileContent = findViewById(R.id.content);

        read.setOnClickListener(this);
        write.setOnClickListener(this);

        botao = findViewById(R.id.info_planeta);
        botao.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                Intent intent = new Intent(Usuario.this,Info.class);
                startActivity(intent);
            }
        });

        botao2 = findViewById(R.id.btnuser);
        botao2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                Intent intent = new Intent(Usuario.this,Home.class);
                startActivity(intent);
            }
        });


        botao4 = findViewById(R.id.btn_teste);
        botao4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                Intent intent = new Intent(Usuario.this, Apiconex.class);
                startActivity(intent);
            }
        });



        botao5 = findViewById(R.id.buscaplaneta);
        botao5.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                 Intent intent = new Intent(Usuario.this, buscaplaneta.class);
                startActivity(intent);
            }
        });
    }


    public void printMessage(String m) {
        Toast.makeText(this, m, Toast.LENGTH_LONG).show();
    }

    @Override
    public void onClick(View view) {
        Button b = (Button) view;

        String b_text = b.getText().toString();

        switch (b_text.toLowerCase()) {
            case "write": {
                writeData();
                break;
            }
            case "read": {
                readData();
                break;
            }
        }
    }

    private void writeData() {

        try {
            FileOutputStream fos = openFileOutput(filename, Context.MODE_PRIVATE);
            String data = userInput.getText().toString();
            fos.write(data.getBytes());
            fos.flush();
            fos.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
        userInput.setText("");
        printMessage("writing to file " + filename + "completed...");
    }

    private void readData() {
        try {
            FileInputStream fin = openFileInput(filename);
            int a;
            StringBuilder temp = new StringBuilder();
            while ((a = fin.read()) != -1) {
                temp.append((char) a);
            }

            fileContent.setText(temp.toString());
            fin.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
        printMessage("reading to file " + filename + " completed..");
    }
}





