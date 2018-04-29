using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public BoardManager boardManager;
    public ProgramModeManager programModeManager;
    public Text boardDisplay;
    public Text LevelPassed;
    public bool programMode = false;
    private bool unlitOnBoard = false;
    public static readonly bool[] InstructionsCheck = new bool[12];

    void Start(){

        //Instatiate Board manager and the Board MVC as a component
        boardManager = new BoardManager();
        boardManager.InstantiateBoardMVC();

        //Instatiate Program manager and the Program MVC as a component
        programModeManager = new ProgramModeManager();
        programModeManager.InstantiateProgramModeMVC();

        //Display initial board setup
        boardDisplay.text = boardManager.boardView.UpdateDisplay();

        //Should return false at the start of a game.
        CheckUnlitTilesOnBoard();
    }
    
    /// <summary>
    /// Loops through the board and checks for any unlit squares. Win condition is all Unlit equal Lit. 
    /// </summary>
    /// <returns></returns>
    public bool CheckUnlitTilesOnBoard(){
        foreach (BoardModel.SquareType tile in boardManager.boardModel.map){
            unlitOnBoard = boardManager.boardModel.CheckIfUnlitSquareType(tile);
            if (unlitOnBoard){
                return unlitOnBoard;
            }
        }
        return unlitOnBoard;
    }

    /// <summary>
    /// This will be called to toggle on/off program mode
    /// </summary>
    public void ProgramMode(){
        programMode = true;
    }

    /// <summary>
    /// OnClick button methods to call each move
    /// </summary>
    public void LigthSquareButton(){
        LightSquare();
    }
    public void WalkNorthButton(){
        WalkNorth();
    }
    public void WalkSouthButton(){
        WalkSouth();
    }
    public void WalkEastButton(){
        WalkEast();
    }
    public void WalkWestButton(){
        WalkWest();
    }
    public void JumpNorthButton(){
        JumpNorth();
    }
    public void JumpSouthButton(){
        JumpSouth();
    }
    public void JumpEastButton(){
        JumpEast();
    }
    public void JumpWestButton(){
        JumpWest();
    }

    /// <summary>
    /// The program mode bool will will be checked to see if true or false. True being activated. If activated the 
    /// move will be stored in a list for the program mode to run later.
    /// After each attemp to light a square there will be a check to see if there are any
    /// more squares left to light up,if there are not, a text will be displayed to show the player has 
    /// completed the level.
    /// </summary>
    public bool LightSquare(){
        if (programMode){
            programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.LIGHTUP);
            return programMode;
        }
        boardManager.boardModel.LightSquare();
        boardDisplay.text = boardManager.boardView.UpdateDisplay();
        if (!CheckUnlitTilesOnBoard())
            LevelPassed.text = boardManager.boardView.LevelWonText();
        return programMode;
    }

    public bool WalkNorth(){
        if (programMode){
            programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.WALK_NORTH);
            return programMode;
        }
        boardManager.boardModel.PlayerWalk(BoardModel.CompassDirection.NORTH);
        boardDisplay.text = boardManager.boardView.UpdateDisplay();
        return programMode;
    }
 
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

    public bool JumpEast(){
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
        programModeManager.programModel.ShowInstructionListInConsole();
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
        */
    }

    public bool GetProgramInstructions(ProgramModeModel.ProgramInstructions instruction){
        return InstructionsCheck[(int)instruction];
    }

    public void Check()
    {
      //need to get match up instruction to commands
    }


    

}
