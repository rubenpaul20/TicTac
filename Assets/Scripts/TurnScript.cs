using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnScript : MonoBehaviour
{
    //variables 
    SpriteRenderer spriteRenderer;
    GameObject gameBoard;
    public Sprite[] images;
    bool unplayed = true;

//function start being created
    private void Start()
    {
        //making sprite renderer
        spriteRenderer.sprite = null;
    }

//function OnMouseDown being created
    private void OnMouseDown()
    {
        //will not allow the player to play twice on the same square
        if (unplayed)
        {
            int index = gameBoard.GetComponent<GameScript>().PlayerTurn();
            spriteRenderer.sprite = images[index];
            unplayed = false;
        }
    }

//function Awake being created 
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameBoard = GameObject.Find("GameBoard");
    }
}
