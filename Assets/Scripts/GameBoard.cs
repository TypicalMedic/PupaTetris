using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    public GameObject tile;
    public Tile[,] board = new Tile[11, 9];

    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i < 11; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                board[i, j] = new Tile(i,j);
            }
        }

        board[8, 0].isBlock = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
