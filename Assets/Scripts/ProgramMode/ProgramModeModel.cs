using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramModeModel{

    public enum ProgramInstructions{
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

    public static readonly int[] Instructions = new int[12];
    public string listOfInstructions;
    bool noInstructionsToPass = true;

    /*
    public void SetProgramInstructionsArray(){
        Instructions[(int)ProgramInstructions.WALK_NORTH] = 0;
        Instructions[(int)ProgramInstructions.WALK_SOUTH] = 1;
        Instructions[(int)ProgramInstructions.WALK_EAST] = 2;
        Instructions[(int)ProgramInstructions.WALK_WEST] = 3;
        Instructions[(int)ProgramInstructions.JUMP_NORTH] = 4;
        Instructions[(int)ProgramInstructions.JUMP_SOUTH] = 5;
        Instructions[(int)ProgramInstructions.JUMP_EAST] = 6;
        Instructions[(int)ProgramInstructions.JUMP_WEST] = 7;
        Instructions[(int)ProgramInstructions.LIGHTUP] = 8;
    }

    public int GetProgramInstructions(ProgramInstructions instruction){
        return Instructions[(int)instruction];
    }
    */

    public List<ProgramInstructions> instructionList = new List<ProgramInstructions>(); 
    public void AddInstructionToProgram(ProgramInstructions instruction){
        instructionList.Add(instruction);
    }

    public void ShowInstructionListInConsole(){
        foreach (ProgramInstructions instruction in instructionList)
            Debug.Log(instruction);
    }

    public ProgramInstructions InvokeInstructions(){
        foreach(ProgramInstructions instruction in instructionList)

           return instruction;

        return instructionList;
    }

    public void ClearCommandsList(){
        instructionList.Clear();
    }
}



 
