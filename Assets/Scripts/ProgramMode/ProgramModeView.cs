using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramModeView{

    private ProgramModeModel model;
    private ProgramModeController controller;
    private string stringProgramCommand = "";

    public static readonly string[] InstructionsToString = new string[12];

    public void SetProgramModel(ProgramModeModel model){
        this.model = model;
    }

    public void SetProgramController(ProgramModeController controller){
        this.controller = controller;
    }

    public void SetProgramInstructionsToStringArray(){
        InstructionsToString[(int)ProgramModeModel.ProgramInstructions.WALK_NORTH] = "Walk North";
        InstructionsToString[(int)ProgramModeModel.ProgramInstructions.WALK_SOUTH] = "Walk South";
        InstructionsToString[(int)ProgramModeModel.ProgramInstructions.WALK_EAST] = "Walk East";
        InstructionsToString[(int)ProgramModeModel.ProgramInstructions.WALK_WEST] = "Walk West";
        InstructionsToString[(int)ProgramModeModel.ProgramInstructions.JUMP_NORTH] = "Jump North";
        InstructionsToString[(int)ProgramModeModel.ProgramInstructions.JUMP_SOUTH] = "Jump South";
        InstructionsToString[(int)ProgramModeModel.ProgramInstructions.JUMP_EAST] = "Jump East";
        InstructionsToString[(int)ProgramModeModel.ProgramInstructions.JUMP_WEST] = "Jump West";
        InstructionsToString[(int)ProgramModeModel.ProgramInstructions.LIGHTUP] = "Light up square";
    }

    public string GetProgramInstructions(ProgramModeModel.ProgramInstructions instruction){
        return InstructionsToString[(int)instruction];
    }
}
