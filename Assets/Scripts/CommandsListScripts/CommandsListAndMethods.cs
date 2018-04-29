using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandsListAndMethods  {

    public List<Func<bool>> CommandsList = new List<Func<bool>>();

    public BoardModel model;

    public void SetModel(BoardModel model){
        this.model = model;
    }

    public void AddLightSquareToCommandsList(){
        CommandsList.Add(model.LightSquare);
    }

    public void AddWalkToCommandList(BoardModel.CompassDirection direction){
        CommandsList.Add(() => model.PlayerWalk(direction));
    }

    public void AddJumpToCommandList(BoardModel.CompassDirection direction){
        CommandsList.Add(() => model.PlayerJump(direction));
    }

    public void InvokeCommands(){
        foreach (Func<bool> command in CommandsList){
            command();
        }      
    }

    public void ShowCommandsListInConsole(){
        foreach (Func<bool> command in CommandsList)
            Debug.Log(command());
    }

    public void ClearCommandsList(){
        CommandsList.Clear();
    }
}
