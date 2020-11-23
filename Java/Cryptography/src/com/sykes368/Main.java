package com.sykes368;

import com.sykes368.gui.*;
import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.Node;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.layout.HBox;
import javafx.scene.layout.Pane;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;

/** Main
 * @author Sykes368
 * @since 1.0
 */
public class Main extends Application {
    private static String currentPage = "Home";

    @Override
    public void start(Stage primaryStage) {
        // Creates Home Button
        Button homeButton = new Button();
        ImageView homeIcon = new ImageView(new Image(UI.ICON_PATH + "home.png"));
        homeButton.setGraphic(homeIcon);
        homeButton.setPadding(Insets.EMPTY);
        homeButton.getStyleClass().add("icon-button");

        // Creates current page label
        Label pageLabel = new Label(currentPage);
        pageLabel.getStyleClass().add("page-label");

        // Creates the top bar
        HBox topBar = new HBox(homeButton, pageLabel);
        topBar.getStyleClass().add("topbar");

        // Creates main layout.
        VBox vBox = new VBox(topBar, HomePage.show(), byLine());

        // Creates background scene
        Scene scene = new Scene(vBox, 1290, 720);
        scene.getStylesheets().add(UI.CSS_PATH);

        // Initializes the stage
        primaryStage.setTitle("Cryptography");
        primaryStage.setScene(scene);
        primaryStage.getIcons().add(new Image("com/sykes368/gui/icons/programIcon.png"));
        primaryStage.show();


        // HomeButton Click method
        homeButton.setOnAction(e -> {
            if(!currentPage.equals("Home")) {
                vBox.getChildren().addAll(HomePage.show(), byLine());
                currentPage = "Home";
            }
        });
    }

    // Adds ByLine
    //TODO: Remove By line After COMSC110 or edit to Sykes368
    private static Node byLine() {
        Label byLineText = new Label("By: Mitchel Sykes");
        byLineText.setPadding(new Insets(0, 5 ,0 ,0));
        byLineText.getStyleClass().add("byline");
        HBox byLine = new HBox(byLineText);
        byLine.setAlignment(Pos.BASELINE_RIGHT);

        return byLine;
    }

    public static void main(String[] args) {
        launch(args);
    }
}