using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class is used to manage the instantiation of the Board MVC component. 
/// Doing it this way will keep the MVC modular and seperate from the other classes.
/// The method InstantiateBoardMVC() will be called in the GameManager at Start, instatiating
/// the MVC as a component.
/// </summary>
public class BoardManager // MonoBehaviour
{    
    public BoardModel boardModel;
    public BoardView boardView;
    public BoardController boardController;
    private LevelLayouts levelLayouts;//Library To be implemented
    private int mapSize;

    public void InstantiateBoardMVC()
    {
        //LevelLayout
        levelLayouts = new LevelLayouts();

        //Model
        boardModel = new BoardModel(mapSize);
        Level3_StartState(boardModel);

        //Controller 
        boardController = new BoardController();
        boardController.SetModel(boardModel);

        //View 
        boardView = new BoardView();
        boardView.SetModel(boardModel);
    }
  
    //Buttons on a screen to select which layout
    //Pssible seperate config file
    public void Level1_StartState(BoardModel boardModel){
        boardModel.mapSize = 4;
        boardModel.playerX = 2;
        boardModel.playerY = 2;
        boardModel.map = levelLayouts.Level1();    
    }

    public void Level2_StartState(BoardModel boardModel){
        boardModel.mapSize = 6;
        boardModel.playerX = 2;
        boardModel.playerY = 2;
        boardModel.map = levelLayouts.Level2();
    }

    public void Level3_StartState(BoardModel boardModel){
        boardModel.mapSize = 10;
        boardModel.playerX = 5;
        boardModel.playerY = 5;
        boardModel.map = levelLayouts.Level3();
    }
 
}

/*
void Start()
{  
    //LevelLayout
    levelLayouts = new LevelLayouts();
    //Model
    model = new LevelModel(mapSize);
    Level3_StartState(model);
    //Controller 
    controller = new LevelController();
    controller.SetModel(model);
    //View 
    view = new LevelView();
    view.SetModel(model);
    UpdateDisplay();
}
*/
