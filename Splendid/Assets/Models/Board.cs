using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board {

    //
    GemPile bankGold;
    GemPile handGold;



    //Constructor
    public Board() {

        bankGold = new GemPile("Gold", 7);

        //GemPile[] bank = new GemPile[6];
        //bank[0].GemType = "Emerald";
        //bank[1].GemType = "Sapphire";
        //bank[2].GemType = "Ruby";
        //bank[3].GemType = "Diamond";
        //bank[4].GemType = "Onyx";
        //bank[5].GemType = "Gold";

        handGold = new GemPile("Gold", 0);

    }

     public void TakeGems(int num) {

        bankGold.NumOfGems = bankGold.NumOfGems - num;
        handGold.NumOfGems = handGold.NumOfGems + num;
        Debug.Log(" bank Gold: " + bankGold.NumOfGems + " hand Gold: " + handGold.NumOfGems);


    }


}
