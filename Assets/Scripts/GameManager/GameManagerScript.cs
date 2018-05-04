using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class will bring all of the other classes to the front for monobehavious
/// </summary>
public class GameManagerScript : MonoBehaviour
{
    public BoardManager boardManager;
    public ProgramCommands programCommands;
    public ProgramManager programManager;
    public Text boardDisplay;
    public Text levelWinCondition;
    public Text programModeInstructions;
    public bool programModeActivated = false;
    public Toggle programModeToggle;

    void Start(){

        //Instatiate Board manager and the Board MVC as a component
        boardManager = new BoardManager();
        boardManager.InstantiateBoardMVC();
        BoardLayout();

        //Instatiate Program manager and the Program MVC as a component
        programManager = new ProgramManager();
        programManager.InstantiateProgramModeMVC();

        //Program commands from program mode will be used from here,add to list, play commands etc.
        //Futute work will involve a different method of saving commands.
        //Script can be found in the Program Commands folder
        programCommands = new ProgramCommands();
        programCommands.SetModel(boardManager.boardModel);

        //Display initial board setup
        boardDisplay.text = boardManager.boardView.UpdateBoardDisplay();

        //Win condition UI and instructions
        levelWinCondition.text = WinConditionStatus();
    }

    public void BoardLayout(){
        boardManager.boardModel.mapSize = BoardLayoutManager.boardLayoutManager.mapSizeLib;
        boardManager.boardModel.map = BoardLayoutManager.boardLayoutManager.mapLib;
        boardManager.boardModel.playerX = BoardLayoutManager.boardLayoutManager.playerXLib;
        boardManager.boardModel.playerY = BoardLayoutManager.boardLayoutManager.playerYLib;
    }

    /// <summary>
    /// Loops through the board and checks for any unlit squares. Win condition is all Unlit equal Lit. 
    /// </summary>
    /// <returns></returns>
    public string WinConditionStatus(){
        foreach(BoardModel.SquareType tile in boardManager.boardModel.map){ 
            if(boardManager.boardModel.CheckIfUnlitSquareType(tile)){
                return boardManager.boardView.UIMoreSquresToLight();
            }
        }
        return boardManager.boardView.UILevelComplete();
    }

    /// <summary>
    /// This will be called to toggle on/off program mode
    /// </summary>
    public void ProgramModeActivated(){//fasle
        bool programModeOn = programModeToggle.isOn;
        if (programModeOn) {
            programModeActivated = true;
        }
        if (!programModeOn){
            programModeActivated = false;
        }
    }

    /// <summary>
    /// Two states, this will tell the button wether program mode is activate.
    /// </summary>
    public void LigthSquareButtonState(){
        if (!programModeActivated){
               boardManager.boardController.LightUpSquare();
        }
        if (programModeActivated){
            programCommands.AddLightSquareToCommandsList();
        }
        levelWinCondition.text= WinConditionStatus();
        boardDisplay.text = boardManager.boardView.UpdateBoardDisplay();     
    }
 
    public void WalkButtonState(BoardModel.CompassDirection direction){
        if (!programModeActivated){
            boardManager.boardController.Walk(direction);  
        }
        if (programModeActivated){
            programCommands.AddWalkToCommandList(direction);
        }
        boardDisplay.text = boardManager.boardView.UpdateBoardDisplay();
    }

    public void JumpButtonState(BoardModel.CompassDirection direction){
        if (!programModeActivated){
            boardManager.boardController.Jump(direction);
        }
        if (programModeActivated){
            programCommands.AddJumpToCommandList(direction);
        }
        boardDisplay.text = boardManager.boardView.UpdateBoardDisplay();     
    }
    /// <summary>
    /// call methods from list
    /// </summary>
    public void PlayProgram(){
        programCommands.PlayCommands();
        boardDisplay.text = boardManager.boardView.UpdateBoardDisplay();
        programCommands.ClearCommandsList();
    }
    /// <summary>
    /// Clear list
    /// </summary>
    public void ClearCommands(){
        programCommands.ClearCommandsList();
        programManager.programModel.ClearStrings();
        programModeInstructions.text = "";
    }
    /// <summary>
    /// 
    /// </summary>
    public void ShowCommands(){
        programCommands.ClearCommandsList();
    }

    /// <summary>
    /// OnClick button methods to call each move
    /// </summary>
    public void LightSquareButton(){
        LigthSquareButtonState();
    }

    /// <summary>
    /// UI buttions, will update text display of their moves
    /// </summary>
    public void WalkNorthButton(){
        WalkButtonState(BoardModel.CompassDirection.NORTH);
        programModeInstructions.text = programManager.programModel.GetProgramInstructions(ProgramModel.ProgramInstructions.WALK_NORTH);
    }

    public void WalkSouthButton(){
        WalkButtonState(BoardModel.CompassDirection.SOUTH);
        programModeInstructions.text = programManager.programModel.GetProgramInstructions(ProgramModel.ProgramInstructions.WALK_SOUTH);
    }

    public void WalkEastButton(){
        WalkButtonState(BoardModel.CompassDirection.EAST);
        programModeInstructions.text = programManager.programModel.GetProgramInstructions(ProgramModel.ProgramInstructions.WALK_EAST);
    }

    public void WalkWestButton(){
        WalkButtonState(BoardModel.CompassDirection.WEST);
        programModeInstructions.text = programManager.programModel.GetProgramInstructions(ProgramModel.ProgramInstructions.WALK_WEST);
    }
    public void JumpNorthButton(){
        JumpButtonState(BoardModel.CompassDirection.NORTH);
        programModeInstructions.text = programManager.programModel.GetProgramInstructions(ProgramModel.ProgramInstructions.JUMP_NORTH);
    }

    public void JumpSouthButton(){
        JumpButtonState(BoardModel.CompassDirection.SOUTH);
        programModeInstructions.text = programManager.programModel.GetProgramInstructions(ProgramModel.ProgramInstructions.JUMP_SOUTH);
    }

    public void JumpEastButton(){
        JumpButtonState(BoardModel.CompassDirection.EAST);
        programModeInstructions.text = programManager.programModel.GetProgramInstructions(ProgramModel.ProgramInstructions.JUMP_EAST);
    }

    public void JumpWestButton(){
        JumpButtonState(BoardModel.CompassDirection.WEST);
        programModeInstructions.text = programManager.programModel.GetProgramInstructions(ProgramModel.ProgramInstructions.JUMP_WEST);
    }
}








































/*

/// <summary>
/// The program mode bool will will be checked to see if true or false. True being activated. If activated the 
/// move will be stored in a list for the program mode to run later.
/// After each attemp to light a square there will be a check to see if there are any
/// more squares left to light up,if there are not, a text will be displayed to show the player has 
/// completed the level.
/// </summary>
public bool LightSquare()
{
    if (programMode)
    {
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.LIGHTUP);
        listDisplay = programModeManager.programModel.GetProgramInstructions(ProgramModeModel.ProgramInstructions.LIGHTUP);

        programModeInstructions.text += listDisplay + "\n";

        return programMode;
    }
    boardManager.boardModel.LightSquare();
    boardDisplay.text = boardManager.boardView.UpdateDisplay();

    if (!CheckUnlitTilesOnBoard())
        LevelPassed.text = boardManager.boardView.LevelWonText();
    return programMode;
}

//Button options
// 2 states
// one command, put into list, played straight from list, reset list? dont reset,

//or program mode, wait until list is complete


//(for methods)
//Option 1 lambdas




/*
public bool WalkNorth()
{
    /*
    if (programMode){
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.WALK_NORTH);
        return programMode;
    }
   
    boardManager.boardModel.PlayerWalk(BoardModel.CompassDirection.NORTH);
    boardDisplay.text = boardManager.boardView.UpdateDisplay();
    return programMode;
}






/*

public bool WalkSouth()
{
    if (programMode)
    {
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.WALK_SOUTH);
        return programMode;
    }
    boardManager.boardModel.PlayerWalk(BoardModel.CompassDirection.SOUTH);
    boardDisplay.text = boardManager.boardView.UpdateDisplay();
    return programMode;
}

public bool WalkEast()
{
    if (programMode)
    {
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.WALK_EAST);
        return programMode;
    }
    boardManager.boardModel.PlayerWalk(BoardModel.CompassDirection.EAST);
    boardDisplay.text = boardManager.boardView.UpdateDisplay();
    return programMode;
}

public bool WalkWest()
{
    if (programMode)
    {
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.WALK_WEST);
        return programMode;
    }
    boardManager.boardModel.PlayerWalk(BoardModel.CompassDirection.WEST);
    boardDisplay.text = boardManager.boardView.UpdateDisplay();
    return programMode;
}

public bool JumpNorth()
{
    if (programMode)
    {
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.JUMP_NORTH);
        return programMode;
    }
    boardManager.boardModel.PlayerJump(BoardModel.CompassDirection.NORTH);
    boardDisplay.text = boardManager.boardView.UpdateDisplay();
    return programMode;
}

public bool JumpSouth()
{
    if (programMode)
    {
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.JUMP_SOUTH);
        return programMode;
    }
    boardManager.boardModel.PlayerJump(BoardModel.CompassDirection.SOUTH);
    boardDisplay.text = boardManager.boardView.UpdateDisplay();
    return programMode;
}

public bool JumpEast()
{
    if (programMode)
    {
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.JUMP_EAST);
        return programMode;
    }
    boardManager.boardModel.PlayerJump(BoardModel.CompassDirection.EAST);
    boardDisplay.text = boardManager.boardView.UpdateDisplay();
    return programMode;
}

public bool JumpWest()
{
    if (programMode)
    {
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.JUMP_WEST);
        return programMode;
    }
    boardManager.boardModel.PlayerJump(BoardModel.CompassDirection.WEST);
    boardDisplay.text = boardManager.boardView.UpdateDisplay();
    return programMode;
}

public void ShowInstructionsList()
{
    programModeManager.programModel.ShowInstructionList();
    GetProgramInstructions(ProgramModeModel.ProgramInstructions.WALK_NORTH);
}

public void CheckProgramInstructions()
{
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

public bool GetProgramInstructions(ProgramModeModel.ProgramInstructions instruction)
{
    return InstructionsCheck[(int)instruction];
}

*/