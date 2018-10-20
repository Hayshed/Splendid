using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemPile {

    string gemType;
    int numOfGems;
    public Text numText;

    public GemPile(string gtype, int num) {
        gemType = gtype;
        NumOfGems = num;
        numText.text = num.ToString();
    }

    public int NumOfGems {
        get {
            return numOfGems;
        }
        set {
            numOfGems = value;
            numText.text = numOfGems.ToString();
        }
    }
}