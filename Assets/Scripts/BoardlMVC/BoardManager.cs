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
    public BoardLibrary boradLibrary;
    public BoardModel boardModel;
    public BoardView boardView;
    public BoardController boardController;
    private int mapSize;

    public void InstantiateBoardMVC()
    {
        //LevelLayout
        boradLibrary = new BoardLibrary();

        //Model
        boardModel = new BoardModel(mapSize);
        //Level3_StartState(boardModel);

        //Controller 
        boardController = new BoardController();
        boardController.SetModel(boardModel);
        boardController.SetView(boardView);

        //View 
        boardView = new BoardView();
        boardView.SetModel(boardModel);   
    }
}

