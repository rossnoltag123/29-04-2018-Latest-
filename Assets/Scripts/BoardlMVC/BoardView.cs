using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System;
using System.Collections;

public class BoardView{

    public string levelCondition;
    public BoardModel model;

    public void SetModel(BoardModel model){    
        this.model = model;
    }

    //String called in controller, from gameMaster
    public string UpdateBoardDisplay(){
        return model.MyToString();
    }

    public string UILevelComplete(){
        return levelCondition = "No more unlit squares\n level complete!!!";  
    }

    public string UIMoreSquresToLight(){
        return levelCondition = "Light the squares!";
    }
}

