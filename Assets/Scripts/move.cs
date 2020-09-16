using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] private GameObject block;
    float fieldWidth, blockWidth;
    float xblock, yblock;
    float lenMove;
    float dir = 0;
    void Start() {
        fieldWidth = this.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        blockWidth = block.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        lenMove = fieldWidth / 10;
        xblock = block.GetComponent<Transform>().position.x + blockWidth / 2;
        yblock = block.GetComponent<Transform>().position.y;
        block.GetComponent<Transform>().position = new Vector2(xblock, yblock);
    }
    void Update()
    {
        if (Input.GetKeyDown("right"))
        {
            dir = 1;
            xblock += lenMove;
            Debug.Log("h");
            //   block.GetComponent<Transform>().position = new Vector2(xblock, yblock);
            block.GetComponent<Rigidbody2D>().transform.Translate(blockWidth, 0, 0);
        }
        else if (Input.GetKeyDown("left")) 
        {
            dir = -1;
            xblock -= lenMove;
            // block.GetComponent<Transform>().position = new Vector2(xblock, yblock);
            block.GetComponent<Rigidbody2D>().transform.Translate(-blockWidth, 0, 0);
        }
        
    }
}
