using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardController : MonoBehaviour {

    public Board board;

	// Use this for initialization

<<<<<<< HEAD
	void OnEnable () {


=======
>>>>>>> parent of d60bd3b... Text display updates with correct number of gems
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
