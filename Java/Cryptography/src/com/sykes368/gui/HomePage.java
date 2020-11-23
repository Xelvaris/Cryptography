package com.sykes368.gui;

import javafx.geometry.Insets;
import javafx.scene.control.Button;
import javafx.scene.control.ScrollPane;
import javafx.scene.layout.FlowPane;

/** HomePage
 * @author Sykes368
 * @since 1.0-g
 */
public class HomePage {
    public static ScrollPane show() {

        Button[] button = new Button[20];
        for (int i = 0; i < 20; i++) {
            button[i] = new Button("Dummy Button");
            button[i].setMinSize(200,200);
            button[i].getStyleClass().add("home-menu-button");
        }
        FlowPane flowPane = new FlowPane();
        flowPane.getStyleClass().add("pane");
        flowPane.setVgap(5);
        flowPane.setHgap(5);
        flowPane.setPadding(new Insets(5));

        for (Button e: button) {
            flowPane.getChildren().add(e);
        }


        ScrollPane scrollPane = new ScrollPane(flowPane);
        scrollPane.setHbarPolicy(ScrollPane.ScrollBarPolicy.NEVER);
        scrollPane.setFitToWidth(true);
        scrollPane.setFitToHeight(true);
        scrollPane.getStyleClass().add("pane");

        return scrollPane;
    }
}
