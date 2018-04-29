using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgramModeManager //MonoBehaviour
{
    public ProgramModeModel programModel;
    public ProgramModeController programController;
    public ProgramModeView programView;
 
    public void InstantiateProgramModeMVC()
    {
        //Model
        programModel = new ProgramModeModel();
      //  programModel.SetProgramInstructionsArray();

        //Controller
        programController = new ProgramModeController();
        programController.SetProgramModel(programModel);
        programController.SetProgramView(programView);

        //View
        programView = new ProgramModeView();
        programView.SetProgramModel(programModel);
        programView.SetProgramController(programController);
    }
}




















/*
void Start () {

    //Model
    model = new ProgramModeModel();

    //Controller
    controller = new ProgramModeController();
    controller.SetProgramModel(model);
    controller.SetProgramView(view);

    //View
    view = new ProgramModeView();
    view.SetProgramModel(model);
    view.SetProgramController(controller);
}
*/
