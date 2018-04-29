using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramModeController {

    private ProgramModeModel model;
    private ProgramModeView view;

    public void SetProgramModel(ProgramModeModel model){
        this.model = model;
    }

    public void SetProgramView(ProgramModeView view){
        this.view = view;
    }

    public void UpdateDisplay(){
     //   string command = "Walk North";
     //   stringProgramCommand += command + "\n";
     //   programDisplay.text = stringProgramCommand;
    }
}
