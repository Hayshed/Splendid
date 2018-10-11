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

    public void takeGemButton() {
        board.TakeGems(1);
        
    }

}
