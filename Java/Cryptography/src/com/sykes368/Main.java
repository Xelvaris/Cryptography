package com.sykes368;

import com.sykes368.gui.*;
import javafx.application.Application;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.Node;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.ScrollPane;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.layout.FlowPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;

/** Main
 * @author Sykes368
 * @since 1.0
 */
public class Main extends Application {
    @Override
    public void start(Stage primaryStage) {
        // Creates Home Button
        Button homeButton = new Button();
        ImageView homeIcon = new ImageView(new Image(UI.ICON_PATH + "home.png"));
        homeButton.setGraphic(homeIcon);
        homeButton.setPadding(Insets.EMPTY);
        homeButton.getStyleClass().add("icon-button");

        // Creates current page label
        Label pageLabel = new Label("Home");
        pageLabel.getStyleClass().add("page-label");

        // Creates the top bar
        HBox topBar = new HBox(homeButton, pageLabel);
        topBar.getStyleClass().add("topbar");


        // Home Menu Buttons
        Button[] buttons = new Button[4];
        for (int i = 0; i < buttons.length; i++) {
            buttons[i] = new Button();
            buttons[i].setMinSize(200,200);
            buttons[i].getStyleClass().add("home-menu-button");
        }

        // Sets the button text
        buttons[0].setText("Caesar");
        buttons[1].setText("Affine");
        buttons[2].setText("Rail-Fence");
        buttons[3].setText("Vigenère");

        // Home page
        FlowPane homePage = new FlowPane();
        homePage.getStyleClass().add("pane");
        homePage.setVgap(5);
        homePage.setHgap(5);
        homePage.setPadding(new Insets(5));

        // Adds the buttons to the home page
        for (Button e: buttons) {
            homePage.getChildren().add(e);
        }

        // View page
        ScrollPane page = new ScrollPane(homePage);
        page.setHbarPolicy(ScrollPane.ScrollBarPolicy.NEVER);
        page.setFitToWidth(true);
        page.setFitToHeight(true);
        page.getStyleClass().add("pane");

        // Creates main layout.
        Node byLine = byLine();
        VBox rootLayout = new VBox(topBar, page, byLine);

        // Creates background scene
        Scene scene = new Scene(rootLayout, 1250, 720);
        scene.getStylesheets().add(UI.CSS_PATH);

        // Initializes the stage
        primaryStage.setTitle("Cryptography");
        primaryStage.setScene(scene);
        primaryStage.getIcons().add(new Image("com/sykes368/gui/icons/programIcon.png"));
        primaryStage.show();


        // HomeButton Click method
        homeButton.setOnAction(e -> {
            if(!pageLabel.getText().equals("Home")) {
                page.setContent(homePage);
                rootLayout.getChildren().add(byLine);
                pageLabel.setText("Home");
            }
        });

        // Caesar Button Click Method
        buttons[0].setOnAction(e -> {
            page.setContent(CaesarPage.show());
            rootLayout.getChildren().remove(2);
            pageLabel.setText("Caesar");
        });

        // Affine Button Click Method
        buttons[1].setOnAction(e -> {
            page.setContent(AffinePage.show());
            rootLayout.getChildren().remove(2);
            pageLabel.setText("Affine");
        });

        // Rail-Fence Button Click Method
        buttons[2].setOnAction(e -> {
            page.setContent(RailFencePage.show());
            rootLayout.getChildren().remove(2);
            pageLabel.setText("Rail-Fence");
        });

        // Vigenere Button Click Method
        buttons[3].setOnAction(e -> {
            page.setContent(VigenerePage.show());
            rootLayout.getChildren().remove(2);
            pageLabel.setText("Vigenère");
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