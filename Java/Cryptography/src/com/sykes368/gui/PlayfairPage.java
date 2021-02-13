package com.sykes368.gui;

import com.sykes368.lib.Playfair;
import javafx.geometry.Insets;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.FlowPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.Pane;
import javafx.scene.layout.VBox;

/** Playfair Page
 * @author Sykes368
 * @since 1.0-g
 */
public class PlayfairPage {
    public static Pane show() {
        // Keyword
        Label keywordLabel = new Label("Keyword: ");
        keywordLabel.getStyleClass().add("box-label");
        TextField keywordText = new TextField();
        keywordText.setPromptText("Enter keyword.");

        HBox keyword = new HBox(keywordLabel, keywordText);

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

        encrypt.setOnAction(e -> outputBox.setText(Playfair.encrypt(keywordText.getText(), inputBox.getText())));

        decrypt.setOnAction(e -> outputBox.setText(Playfair.decrypt(keywordText.getText(), inputBox.getText())));


        VBox uiControls = new VBox(keyword, input, output, buttons);
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
