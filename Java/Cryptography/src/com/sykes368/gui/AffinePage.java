package com.sykes368.gui;

import com.sykes368.lib.Affine;
import javafx.geometry.Insets;
import javafx.scene.control.Button;
import javafx.scene.control.ComboBox;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.FlowPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.Pane;
import javafx.scene.layout.VBox;

public class AffinePage {
    public static Pane show() {

        // a
        Label aLabel = new Label("a: ");
        aLabel.getStyleClass().add("box-label");
        ComboBox<Integer> aNum = new ComboBox<>();
        aNum.getItems().addAll(1,3,5,7,9,11,15,17,19,21,23,25);
        aNum.setValue(1);
        HBox aBox = new HBox(aLabel, aNum);

        // b
        Label bLabel = new Label("b: ");
        bLabel.getStyleClass().add("box-label");
        TextField bNum = new TextField();
        bNum.setPromptText("Enter a Number.");

        HBox bBox = new HBox(bLabel, bNum);

        // Parameters
        HBox paramBox = new HBox(aBox, bBox);
        paramBox.setSpacing(20);

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
            if (!bNum.getText().matches("^[0-9]+$")) {
                outputBox.setText("[ERROR]: The b value must be a positive number");
            } else {
                int b = Integer.parseInt(bNum.getText());
                outputBox.setText(Affine.encrypt(aNum.getValue(), b, inputBox.getText()));
            }
        });

        decrypt.setOnAction(e -> {
            if (!bNum.getText().matches("^[0-9]+$")) {
                outputBox.setText("[ERROR]: The b value must be a positive number");
            } else {
                int b = Integer.parseInt(bNum.getText());
                outputBox.setText(Affine.decrypt(aNum.getValue(), b, inputBox.getText()));
            }
        });



        VBox uiControls = new VBox(paramBox, input, output, buttons);
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
