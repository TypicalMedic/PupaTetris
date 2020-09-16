using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    int x, y;
    public bool isBlock;

    public Tile(int newX, int newY)
    {
        x = newX;
        y = newY;
    }

}
