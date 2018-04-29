using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System;
using System.Collections;

public class BoardView{
 
    public BoardModel model;

    public void SetModel(BoardModel model){    
         this.model = model;
    }

    public string LevelWonText(){
        string LevelWon = "No more unlit squares\n level complete!!!";
        return LevelWon;
    }

    //Might have to go to Controller..Makes sense for a display feature to be in vew?Coming from model?
    public string UpdateDisplay(){
        return model.MyToString();
    }


}

