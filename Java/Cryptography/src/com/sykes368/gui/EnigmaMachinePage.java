package com.sykes368.gui;

import com.sykes368.lib.enigma.Enigma;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.control.Button;
import javafx.scene.control.ComboBox;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.FlowPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.Pane;
import javafx.scene.layout.VBox;

/** EnigmaMachine Page
 * @author Sykes368
 * @since 1.0-g
 */
public class EnigmaMachinePage {
    public static Pane show() {
        // Settings
        // Rotor select
        String[] rotorOptions = {"I", "II", "III", "IV", "V"};
        ComboBox<String> rotor1 = new ComboBox<>();
        ComboBox<String> rotor2 = new ComboBox<>();
        ComboBox<String> rotor3 = new ComboBox<>();
        rotor1.getItems().addAll(rotorOptions);
        rotor2.getItems().addAll(rotorOptions);
        rotor3.getItems().addAll(rotorOptions);
        rotor1.setValue("I");
        rotor2.setValue("II");
        rotor3.setValue("III");

        HBox rotorSelect = new HBox(rotor1, rotor2, rotor3);
        rotorSelect.setSpacing(20);
        rotorSelect.setAlignment(Pos.CENTER);

        // Ring positions
        ComboBox<Character> rotor1Ring = new ComboBox<>();
        ComboBox<Character> rotor2Ring = new ComboBox<>();
        ComboBox<Character> rotor3Ring = new ComboBox<>();
        rotor1Ring.getItems().addAll('A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z');
        rotor2Ring.getItems().addAll('A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z');
        rotor3Ring.getItems().addAll('A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z');
        rotor1Ring.setValue('A');
        rotor2Ring.setValue('A');
        rotor3Ring.setValue('A');

        HBox rotorRingSelect = new HBox(rotor1Ring, rotor2Ring, rotor3Ring);
        rotorRingSelect.setSpacing(20);
        rotorRingSelect.setAlignment(Pos.CENTER);

        // Rotor Start Positions
        ComboBox<Character> rotor1Start = new ComboBox<>();
        ComboBox<Character> rotor2Start = new ComboBox<>();
        ComboBox<Character> rotor3Start = new ComboBox<>();
        rotor1Start.getItems().addAll('A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z');
        rotor2Start.getItems().addAll('A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z');
        rotor3Start.getItems().addAll('A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z');
        rotor1Start.setValue('A');
        rotor2Start.setValue('A');
        rotor3Start.setValue('A');

        HBox rotorStartSelect = new HBox(rotor1Start, rotor2Start, rotor3Start);
        rotorStartSelect.setSpacing(20);
        rotorStartSelect.setAlignment(Pos.CENTER);

        // Reflector
        Label reflectLabel = new Label("Reflector: ");
        reflectLabel.getStyleClass().add("box-label");
        ComboBox<Character> reflectBox = new ComboBox<>();
        reflectBox.getItems().addAll('A', 'B', 'C');
        reflectBox.setValue('B');

        HBox reflector = new HBox(reflectLabel, reflectBox);

        // Plugs
        Label plugLabel = new Label("Plugs: ");
        plugLabel.getStyleClass().add("box-label");
        TextField plugBox = new TextField();
        plugBox.setPrefWidth(500);
        plugBox.setPromptText("Enter plug pairs. You can input up to 10 pairs with no repeating letters format: AB EX DC TH");

        VBox plugBoard = new VBox(plugLabel, plugBox);

        VBox settings = new VBox(rotorSelect, rotorRingSelect, rotorStartSelect, reflector, plugBoard);
        settings.setSpacing(10);
        settings.setAlignment(Pos.CENTER);

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
        Button start = new Button("Start");

        HBox button = new HBox(start);
        button.getStyleClass().add("");
        button.setSpacing(20);

        start.setOnAction(e -> {
            String rings = "" + rotor1Ring.getValue() + rotor2Ring.getValue() + rotor3Ring.getValue();
            String rotors = rotor1.getValue() + "-" + rotor2.getValue() + "-" + rotor3.getValue();
            String rotorStart = "" + rotor1Start.getValue() + rotor2Start.getValue() + rotor3Start.getValue();
            outputBox.setText(Enigma.Start(inputBox.getText(), rings, rotors, "" + (char)reflectBox.getValue(), plugBox.getText(), rotorStart));
        });

        VBox uiControls = new VBox(settings, input, output, button);
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
