using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardController : MonoBehaviour {

    public static BoardController Instance { get; protected set; }

    public Board board;

	// Use this for initialization
	void Start () {

        if (Instance != null) {
            Debug.LogError("There should never be two board controllers.");
        }
        Instance = this;


        board = new Board();

	}
	
	// Update is called once per frame
	void Update () {
        
		
	}


    //Button to take gems
    // This is the function that a game object button connects to when you click on a gem pile
    // Will be replaced by general button function, and set different for each button
    public void takeGemButton() {
        board.TakeGems(1);

        
    }

    //TEMPORARY
    //Button to move gems from from purchase pile to bank pile
    // Will be replaced by general button function, and set different for each button
    public void giveGemButton() {
        board.TakeGems(-1);
    }

}
