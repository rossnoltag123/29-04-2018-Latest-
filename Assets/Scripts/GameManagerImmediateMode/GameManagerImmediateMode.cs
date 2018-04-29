using UnityEngine;
using UnityEngine.UI;

public class GameManagerImmediateMode : MonoBehaviour
{
    private BoardModel levelModel;

    void Start()
    {
        print("Game Manager - start ");
        int mapSize = 10;
        levelModel = new BoardModel(mapSize);
        levelModel.playerX = 9;
        levelModel.playerY = 3;
        levelModel.map = Level1();

        //----
        UpdateDisplay();
    }

    private BoardModel.SquareType[,] Level1()
    {
        return new BoardModel.SquareType[,]
            {
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD,BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.TARGET_H2_UNLIT, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H2, BoardModel.SquareType.IMPASSABLE_PIT, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.IMPASSABLE_VOLCANO, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD,BoardModel.SquareType.EDGE_OF_BOARD}
            };
    }

    private BoardModel.SquareType[,] Level2()
    {
        return new BoardModel.SquareType[,]
            {
            { BoardModel.SquareType.TARGET_H0_UNLIT, BoardModel.SquareType.TARGET_H0_UNLIT, BoardModel.SquareType.TARGET_H0_UNLIT },
            { BoardModel.SquareType.TARGET_H0_UNLIT, BoardModel.SquareType.TARGET_H0_UNLIT, BoardModel.SquareType.TARGET_H0_UNLIT },
            { BoardModel.SquareType.TARGET_H0_UNLIT, BoardModel.SquareType.TARGET_H0_UNLIT, BoardModel.SquareType.TARGET_H0_UNLIT }
            };
    }

    void Update()
    {
        //        UpdateDisplay(levelModel);
    }

    private void UpdateDisplay()
    {
        print(levelModel.MyToString());

    }

    public void ACTION_LightUp()
    {
        levelModel.LightSquare();
        UpdateDisplay();
    }

    public void ACTION_WalkNORTH()
    {
        levelModel.PlayerWalk(BoardModel.CompassDirection.NORTH);
        UpdateDisplay();
    }

    public void ACTION_WalkSOUTH()
    {
        levelModel.PlayerWalk(BoardModel.CompassDirection.SOUTH);
        UpdateDisplay();
    }

    public void ACTION_WalkEAST()
    {
        levelModel.PlayerWalk(BoardModel.CompassDirection.EAST);
        UpdateDisplay();
    }

    public void ACTION_WalkWEST()
    {
        levelModel.PlayerWalk(BoardModel.CompassDirection.WEST);
        UpdateDisplay();
    }

    public void ACTION_JumpNORTH()
    {
        levelModel.PlayerJump(BoardModel.CompassDirection.NORTH);
        UpdateDisplay();
    }

    public void ACTION_JumpSOUTH()
    {
        levelModel.PlayerJump(BoardModel.CompassDirection.SOUTH);
        UpdateDisplay();
    }

    public void ACTION_JumpEAST()
    {
        levelModel.PlayerJump(BoardModel.CompassDirection.EAST);
        UpdateDisplay();
    }

    public void ACTION_JumpWEST()
    {
        levelModel.PlayerJump(BoardModel.CompassDirection.WEST);
        UpdateDisplay();
    }
}

