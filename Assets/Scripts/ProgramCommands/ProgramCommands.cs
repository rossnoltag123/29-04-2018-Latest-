using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramCommands{

    /// <summary>
    /// <Func<bool>> allows to store a method with a return type bool
    /// </summary>
    public List<Func<bool>> programCommands = new List<Func<bool>>();
    public BoardModel model;

    public void SetModel(BoardModel model){
        this.model = model;
    }

    public void AddLightSquareToCommandsList(){
        programCommands.Add(model.LightSquare);
    }

    /// <summary>
    /// This => is a lambdas expresion. This () signifies method.
    /// </summary>
    /// <param name="direction"></param>
    public void AddWalkToCommandList(BoardModel.CompassDirection direction){
        programCommands.Add(() => model.PlayerWalk(direction));
    }

    public void AddJumpToCommandList(BoardModel.CompassDirection direction){
        programCommands.Add(() => model.PlayerJump(direction));
    }

    public void PlayCommands(){
        foreach (Func<bool> command in programCommands){
            command();
        }      
    }

    public void ShowCommandsListInConsole(){
        foreach (Func<bool> command in programCommands)
            Debug.Log(command());
    }

    public void ClearCommandsList(){
        programCommands.Clear();
    }
}
