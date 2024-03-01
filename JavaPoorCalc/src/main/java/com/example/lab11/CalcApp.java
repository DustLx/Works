package com.example.lab11;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.stage.Stage;

import java.io.IOException;

public class CalcApp extends Application {
    @Override
    public void start(Stage stage) throws IOException {
        FXMLLoader fxmlLoader = new FXMLLoader(CalcApp.class.getResource("app-view.fxml"));
        Scene scene = new Scene(fxmlLoader.load(), 500, 300);
        // stage.setResizable(false);
        stage.setTitle("Калькулятор режима \"Программист\"");
        stage.setScene(scene);
        stage.show();
    }

    public static void main(String[] args) {
        launch();
    }


}


