using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProgramController{

    private BoardController boardController;
    public BoardModel boardModel;
    private ProgramModel model;
    private ProgramView view;

    public void SetBoardModel(BoardModel boardModel)
    {
        this.boardModel = boardModel;
    }
    public void SetBoardController(BoardController boardController){
        this.boardController = boardController;
    }
    public void SetProgramModel(ProgramModel model){
        this.model = model;
    }
    public void SetProgramView(ProgramView view){
        this.view = view;
    }
 

    










/*
    public static readonly bool[] Instructions = new bool[12];

    public void SetProgramInstructions()
    {
        Instructions[(int)ProgramModel.ProgramInstructions.WALK_NORTH] = boardController.Walk(BoardModel.CompassDirection.NORTH);
        /*
        InstructionsToString[(int)ProgramInstructions.WALK_SOUTH] = "Walk South";
        InstructionsToString[(int)ProgramInstructions.WALK_EAST] = "Walk East";
        InstructionsToString[(int)ProgramInstructions.WALK_WEST] = "Walk West";
        InstructionsToString[(int)ProgramInstructions.JUMP_NORTH] = "Jump North";
        InstructionsToString[(int)ProgramInstructions.JUMP_SOUTH] = "Jump South";
        InstructionsToString[(int)ProgramInstructions.JUMP_EAST] = "Jump East";
        InstructionsToString[(int)ProgramInstructions.JUMP_WEST] = "Jump West";

    }

    public bool GetProgramInstructions(ProgramModel.ProgramInstructions instruction)
    {
        bool success = Instructions[(int)instruction];
        return success;
    }
*/

    /*
      public void SetProgramInstructions(){
          Instructions[(int)ProgramModel.ProgramInstructions.WALK_NORTH] = BoardModel.CompassDirection.NORTH;
          /*
          InstructionsToString[(int)ProgramInstructions.WALK_SOUTH] = "Walk South";
          InstructionsToString[(int)ProgramInstructions.WALK_EAST] = "Walk East";
          InstructionsToString[(int)ProgramInstructions.WALK_WEST] = "Walk West";
          InstructionsToString[(int)ProgramInstructions.JUMP_NORTH] = "Jump North";
          InstructionsToString[(int)ProgramInstructions.JUMP_SOUTH] = "Jump South";
          InstructionsToString[(int)ProgramInstructions.JUMP_EAST] = "Jump East";
          InstructionsToString[(int)ProgramInstructions.JUMP_WEST] = "Jump West";
          InstructionsToString[(int)ProgramInstructions.LIGHTUP] = "Light up square";

      }

      public string GetProgramInstructions(ProgramModel.ProgramInstructions instruction){
          listToDisplay = Instructions[(int)instruction];
          return listToDisplay;
      }
  */
    /// <summary>
    /// The program mode bool will will be checked to see if true or false. True being activated. If activated the 
    /// move will be stored in a list for the program mode to run later.
    /// After each attemp to light a square there will be a check to see if there are any
    /// more squares left to light up,if there are not, a text will be displayed to show the player has 
    /// completed the level.
    /// </summary>
    /// 
    /*
    public void LightSquareInstruction(){ 
        model.AddLightUpInstructionToProgram();
    }
    */
    /*
    public void WalkNorthInstruction(){
    
        model.AddWalkInstructionToProgram(ProgramModel.ProgramInstructions.WALK_NORTH);
    }
    /*
    public void WalkSouthInstruction(){
        model.AddWalkInstructionToProgram(ProgramModel.ProgramInstructions.WALK_SOUTH);
    }

    public void WalkEastInstruction(){
        model.AddWalkInstructionToProgram(ProgramModel.ProgramInstructions.WALK_EAST);
    }

    public void WalkWestInstruction(){
        model.AddWalkInstructionToProgram(ProgramModel.ProgramInstructions.WALK_WEST);
    }

    public void JumpNorthInstruction(){
        model.AddWalkInstructionToProgram(ProgramModel.ProgramInstructions.JUMP_NORTH);
    }
    /*
    public void JumpSouthInstruction(){
        model.AddJumpInstructionToProgram(ProgramModel.ProgramInstructions.JUMP_SOUTH);
    }

    public void JumpEastInstruction(){
        model.AddJumpInstructionToProgram(ProgramModel.ProgramInstructions.JUMP_EAST);
    }

    public void JumpWestInstruction(){
        model.AddJumpInstructionToProgram(ProgramModel.ProgramInstructions.JUMP_WEST);
    }
    */
    //Button options
    // 2 states
    // one command, put into list, played straight from list, reset list? dont reset,
    //or program mode, wait until list is complete
    //(for methods)
    //Option 1 lambdas

    /*
        public bool WalkNorth()
        {

            if (programMode){
                programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.WALK_NORTH);
                return programMode;
            }

            boardManager.boardModel.PlayerWalk(BoardModel.CompassDirection.NORTH);
            boardDisplay.text = boardManager.boardView.UpdateDisplay();
            return programMode;
            */
    /*

    public bool WalkSouth(){
        if (programMode){
            programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.WALK_SOUTH);
            return programMode;
        }
        boardManager.boardModel.PlayerWalk(BoardModel.CompassDirection.SOUTH);
        boardDisplay.text = boardManager.boardView.UpdateDisplay();
        return programMode;
    }

    public bool WalkEast(){
        if (programMode){
            programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.WALK_EAST);
            return programMode;
        }
        boardManager.boardModel.PlayerWalk(BoardModel.CompassDirection.EAST);
        boardDisplay.text = boardManager.boardView.UpdateDisplay();
        return programMode;
    }

    public bool WalkWest(){
        if (programMode){
            programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.WALK_WEST);
            return programMode;
        }
        boardManager.boardModel.PlayerWalk(BoardModel.CompassDirection.WEST);
        boardDisplay.text = boardManager.boardView.UpdateDisplay();
        return programMode;
    }

    public bool JumpNorth(){
        if (programMode){
            programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.JUMP_NORTH);
            return programMode;
        }
        boardManager.boardModel.PlayerJump(BoardModel.CompassDirection.NORTH);
        boardDisplay.text = boardManager.boardView.UpdateDisplay();
        return programMode;
    }

    public bool JumpSouth(){
        if (programMode){
            programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.JUMP_SOUTH);
            return programMode;
        }
        boardManager.boardModel.PlayerJump(BoardModel.CompassDirection.SOUTH);
        boardDisplay.text = boardManager.boardView.UpdateDisplay();
        return programMode;
    }

    public bool JumpEast()
    {
        if (programMode){
            programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.JUMP_EAST);
            return programMode;
        }
        boardManager.boardModel.PlayerJump(BoardModel.CompassDirection.EAST);
        boardDisplay.text = boardManager.boardView.UpdateDisplay();
        return programMode;
    }

    public bool JumpWest(){
        if (programMode){
            programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.JUMP_WEST);
            return programMode;
        }
        boardManager.boardModel.PlayerJump(BoardModel.CompassDirection.WEST);
        boardDisplay.text = boardManager.boardView.UpdateDisplay();
        return programMode;
    }

    public void ShowInstructionsList(){
        programModeManager.programModel.ShowInstructionList();
        GetProgramInstructions(ProgramModeModel.ProgramInstructions.WALK_NORTH);
    }

    public void CheckProgramInstructions(){
        InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.WALK_NORTH] = boardManager.boardModel.PlayerWalk(BoardModel.CompassDirection.NORTH);
        /*
        InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.WALK_SOUTH] = 1;
        InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.WALK_EAST] = 2;
        InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.WALK_WEST] = 3;
        InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.JUMP_NORTH] = 4;
        InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.JUMP_SOUTH] = 5;
        InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.JUMP_EAST] = 6;
        InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.JUMP_WEST] = 7;
        InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.LIGHTUP] = 8;
        
    }

    public bool GetProgramInstructions(ProgramModeModel.ProgramInstructions instruction){
        return InstructionsCheck[(int)instruction];
    }
    */
}
