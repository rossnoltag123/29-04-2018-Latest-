using UnityEngine;
using System.Collections;
using System;

public class BoardController 
{ 
    public BoardModel model;
    public BoardView view;

    public void SetModel(BoardModel model){
        this.model = model;
    }

    public void SetView(BoardView view){
        this.view = view; 
    }

    /*
    public void LightUpSquare(){
        model.LightSquare();
    }
    
    public bool WalkNORTH(){
        Debug.Log("BoardWalkNorth");
        return model.PlayerWalk(BoardModel.CompassDirection.NORTH);
    }

    public void WalkSOUTH(){
        model.PlayerWalk(BoardModel.CompassDirection.SOUTH);
    }

    public void WalkEAST(){
        model.PlayerWalk(BoardModel.CompassDirection.EAST);
    }

    public void WalkWEST(){
        model.PlayerWalk(BoardModel.CompassDirection.WEST);
    }

    public void JumpNORTH(){
        model.PlayerJump(BoardModel.CompassDirection.NORTH);
    }

    public void JumpSOUTH(){
        model.PlayerJump(BoardModel.CompassDirection.SOUTH);
    }

    public void JumpEAST(){
        model.PlayerJump(BoardModel.CompassDirection.EAST);
    }

    public void JumpWEST(){
        model.PlayerJump(BoardModel.CompassDirection.WEST);
    }
    */
}
