package com.sykes368.gui;

import javafx.geometry.Insets;
import javafx.scene.layout.FlowPane;
import javafx.scene.layout.Pane;
import javafx.scene.layout.VBox;

/** Main
 * @author Sykes368
 * @since 1.0-g
 */
public class CaesarPage {
    public static Pane show() {

        VBox uiControls = new VBox();

        // Creates flowPane with padding of 5
        FlowPane flowPane = new FlowPane();
        flowPane.setHgap(5);
        flowPane.setVgap(5);
        flowPane.setPadding(new Insets(5));

        return flowPane;
    }
}
