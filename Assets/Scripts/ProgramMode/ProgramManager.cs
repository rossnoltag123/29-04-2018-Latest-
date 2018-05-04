using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgramManager //MonoBehaviour
{
    public BoardController boardController;
    public BoardModel programboardModel;
    public ProgramModel programModel;
    public ProgramController programController;
    public ProgramView programView;
 
    public void InstantiateProgramModeMVC()
    {
        //Model
        programModel = new ProgramModel();
        programModel.SetProgramInstructions();
        //programModel.SetProgramInstructionsArray();

        //Controller
        programController = new ProgramController();
        // programController.SetProgramModel(programModel);
        // programController.SetProgramView(programView);
        // programController.SetBoardController(boardController);
        // programController.SetBoardModel(programboardModel);

        //View
        programView = new ProgramView();
        programView.SetProgramModel(programModel);
        programView.SetProgramController(programController);
    }
}




















