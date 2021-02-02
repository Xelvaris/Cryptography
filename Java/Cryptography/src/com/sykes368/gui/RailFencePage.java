package com.sykes368.gui;

import com.sykes368.lib.RailFence;
import javafx.geometry.Insets;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.FlowPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.Pane;
import javafx.scene.layout.VBox;

public class RailFencePage {
    public static Pane show() {
        // Rails
        Label railsLabel = new Label("Rails: ");
        railsLabel.getStyleClass().add("box-label");
        TextField railNum = new TextField();
        railNum.setPromptText("Enter a Number.");

        HBox rails = new HBox(railsLabel, railNum);

        // Input
        Label inputLabel = new Label("Input: ");
        inputLabel.getStyleClass().add("box-label");
        TextField inputBox = new TextField();
        inputBox.setPrefWidth(500);
        inputBox.setPromptText("Enter text to encrypt or decrypt.");

        VBox input = new VBox(inputLabel, inputBox);

        // Output
        Label outputLabel = new Label("Output: ");
        outputLabel.getStyleClass().add("box-label");
        TextField outputBox = new TextField();
        outputBox.setPrefWidth(500);
        outputBox.setPromptText("...");
        outputBox.setDisable(true);

        VBox output = new VBox(outputLabel, outputBox);

        // Control Buttons
        Button encrypt = new Button("Encrypt");

        Button decrypt = new Button("Decrypt");

        HBox buttons = new HBox(encrypt, decrypt);
        buttons.getStyleClass().add("");
        buttons.setSpacing(20);

        encrypt.setOnAction(e -> {
            if (!railNum.getText().matches("^[0-9]+$")) {
                outputBox.setText("[ERROR]: The number of rails must be a positive number");
            } else {
                int r = Integer.parseInt(railNum.getText());
                outputBox.setText(RailFence.encrypt(r, inputBox.getText()));
            }
        });

        decrypt.setOnAction(e -> {
            if (!railNum.getText().matches("^[0-9]+$")) {
                outputBox.setText("[ERROR]: The number of rails must be a positive number");
            } else {
                int r = Integer.parseInt(railNum.getText());
                outputBox.setText(RailFence.decrypt(r, inputBox.getText()));
            }
        });



        VBox uiControls = new VBox(rails, input, output, buttons);
        uiControls.setSpacing(10);

        // Creates flowPane with padding of 5
        // Required to add info page and challenge in future.
        FlowPane flowPane = new FlowPane();
        flowPane.getStyleClass().add("pane");
        flowPane.setHgap(5);
        flowPane.setVgap(5);
        flowPane.setPadding(new Insets(5));
        flowPane.getChildren().addAll(uiControls);

        return flowPane;
    }
}
