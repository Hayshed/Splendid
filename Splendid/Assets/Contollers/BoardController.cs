using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour {

    public Board board;

	// Use this for initialization
	void OnEnable () {

        board = new Board();
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}


    //Button to take gems
    // This is the function that a game object button connects to when you click on a gem pile
    public void takeGemButton() {
        board.TakeGems(1);
        
                    
        
    }

}
