using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject gameBoard;
    private int x, y;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(6, 0);
        x = 6;
        y = 0;  
    }

    // Update is called once per frame
    void Update()
    {

        //horizontalInput = Input.GetAxis("Horizontal");
        //if (horizontalInput < 0)
        //{
        //    transform.Translate(Vector2.left * 0.1f);
        //}
        //if (horizontalInput > 0)
        //{
        //    transform.Translate(Vector2.right * 0.1f);
        //}

        if (Input.GetKeyDown(KeyCode.LeftArrow) && !gameBoard.GetComponent<GameBoard>().board[x-1,y].isBlock)
        {
            transform.Translate(Vector2.left * 1f);
            x = (int)transform.position.x;
            y = (int)transform.position.y;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && !gameBoard.GetComponent<GameBoard>().board[x+1, y].isBlock)
        {
            transform.Translate(Vector2.right * 1f);
            x = (int)transform.position.x;
            y = (int)transform.position.y;
        }
    }
}
