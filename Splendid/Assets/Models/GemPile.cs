using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPile {

    string gemType;
    int numOfGems;

    public GemPile(string gemType, int numOfGems) {

        this.gemType = gemType;
        this.NumOfGems = numOfGems;

    }

    public int NumOfGems {
        get {
            return numOfGems;
        }

        set {
            numOfGems = value;
        }
    }
}