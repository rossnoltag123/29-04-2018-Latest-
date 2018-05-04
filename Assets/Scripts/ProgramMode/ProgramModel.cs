using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramModel {
    public enum ProgramInstructions {
        WALK_NORTH,
        WALK_SOUTH,
        WALK_EAST,
        WALK_WEST,
        JUMP_NORTH,
        JUMP_SOUTH,
        JUMP_EAST,
        JUMP_WEST,
        LIGHTUP
    };

    public string instructionString = "";
    public string listToDisplay = "";
    public static readonly string[] Instructions = new string[12];

    public void SetProgramInstructions() {
        Instructions[(int)ProgramInstructions.WALK_NORTH] = "Walk North";
        Instructions[(int)ProgramInstructions.WALK_SOUTH] = "Walk South";
        Instructions[(int)ProgramInstructions.WALK_EAST] = "Walk East";
        Instructions[(int)ProgramInstructions.WALK_WEST] = "Walk West";
        Instructions[(int)ProgramInstructions.JUMP_NORTH] = "Jump North";
        Instructions[(int)ProgramInstructions.JUMP_SOUTH] = "Jump South";
        Instructions[(int)ProgramInstructions.JUMP_EAST] = "Jump East";
        Instructions[(int)ProgramInstructions.JUMP_WEST] = "Jump West";
        Instructions[(int)ProgramInstructions.LIGHTUP] = "Light up square";
    }

    public string GetProgramInstructions(ProgramInstructions instruction) {
        string listToDisplay = Instructions[(int)instruction];
        instructionString += listToDisplay + "\n";
        return instructionString;
    }

    public void ClearStrings(){
        instructionString = "";
        listToDisplay = "";
    }  
}

