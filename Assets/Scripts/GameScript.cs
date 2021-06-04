using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    //variables
    int spriteIndex = -1;
    //player turn function is being created
    public int PlayerTurn()
    {
        //sprite index being incremented 
        spriteIndex++;
        //sprite index being returned
        return spriteIndex % 2;
    }
}
