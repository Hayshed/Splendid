using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board {

    //TODO: Add different types of piles, not just two gold piles
    // Use arrays/lists of GemPiles? 1 each for bank, purchase, refund, and each hand

    GemPile bankGold;
    GemPile tempGold;



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

        tempGold = new GemPile("Gold", 0);

    }

    // Lowers the Gem count of one gempile and adds to another
    // TODO:    Make usable for more than one case
    // Want to be able to pass in the type of gem (Which will be hardcoded to each button).
    // For now we will assume that this is just for taking a gem from the bank and putting it into the temp/purchase piles

     public void TakeGems(int num) {

        bankGold.NumOfGems = bankGold.NumOfGems - num;
        tempGold.NumOfGems = tempGold.NumOfGems + num;
        Debug.Log(" bank Gold: " + bankGold.NumOfGems + " hand Gold: " + tempGold.NumOfGems);
        //TODO: Connect model of Gempiles to display so we can see the number of gems go up and down


    }


}
