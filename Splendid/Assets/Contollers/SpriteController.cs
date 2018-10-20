using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Sets up Visual Layout of game and links these visuals to the model
/// </summary>
public class SpriteController : MonoBehaviour {

    public Sprite Diamond_Sprite;
    public Sprite Emerald_Sprite;
    public Sprite Gold_Sprite;
    public Sprite Onyx_Sprite;
    public Sprite Ruby_Sprite;
    public Sprite Sapphire_Sprite;

    GameObject bankPanel;
    GameObject gemPilePanel;
    GameObject gemSlot;

    int maxNumOfGems = 7;

    Text text;

    Dictionary<GemPile, GameObject> gemPile_to_GameObjectMap;

    Text displayBank;
    Text displayPurchase;

    // Use this for initialization
    void Start () {


        displayBank = GameObject.Find("Canvas/Bank_Panel/GoldPile/Text").GetComponent<Text>();
        displayPurchase = GameObject.Find("Canvas/Purchase_Panel/GoldPile/Text").GetComponent<Text>();

        displayBank.text = "2";
        displayPurchase.text = "4";


        //FIXME: testing ablity to change sprites in Canvas
        //Sprite sr = GameObject.Find("Canvas/Bank_Panel/GoldPile/Image").GetComponent<Sprite>();
        //sr = Ruby_Sprite;
        //Debug.Log("Try to change sprite -- test");




        ////// Each gemPile will be linked to a GameObject that visually represents it
        ////gemPile_to_GameObjectMap = new Dictionary<GemPile, GameObject>();

        ////// Make the bank panel, which holds all gempiles
        ////bankPanel = new GameObject("Bank_Panel");
        ////bankPanel.transform.position = new Vector3(0, 0, 0);
        ////bankPanel.transform.SetParent(this.transform, true);

        //////Add in gempiles as children to the bank panel
        ////gemPilePanel = new GameObject("GemPile_Panel");
        ////gemPilePanel.transform.position = new Vector3(0, 0, 0);
        ////gemPilePanel.transform.SetParent(bankPanel.transform, true);

        //////TODO: add button capalbity - click on a gempile should result in gems moving around 
        ////// Could stay as UI and put this all in a canvas, or have these have a set location out of UI, but that requires checking where the mouse is manually.. ew
        //////gemPilePanel.AddComponent<Bu>

        //////Add in gemslots as children
        ////for (int i = 0; i < maxNumOfGems; i++) {
        ////    gemSlot = new GameObject("GemSlot_Sprite_" + i);


        ////    SpriteRenderer sr = gemSlot.AddComponent<SpriteRenderer>();
        ////    sr.sprite = Gold_Sprite;

        ////    gemSlot.transform.localScale = new Vector2(0.5f, 0.5f);
        ////    gemSlot.transform.position = new Vector3(sr.sprite.bounds.size.x * i * 0.5f, 0, 0);
        ////    gemSlot.transform.SetParent(gemPilePanel.transform, true);


        ////}



        //sr.sortingLayerName = "Tiles"; // set a sorting layer?





        //    GameObject newCanvas = new GameObject("Canvas");
        //Canvas c = newCanvas.AddComponent<Canvas>();
        //c.renderMode = RenderMode.ScreenSpaceOverlay;
        //newCanvas.AddComponent<CanvasScaler>();
        //newCanvas.AddComponent<GraphicRaycaster>();
        //GameObject panel = new GameObject("Panel");
        //panel.AddComponent<CanvasRenderer>();
        //Image i = panel.AddComponent<Image>();
        //i.color = Color.red;
        //panel.transform.SetParent(newCanvas.transform, false);


    }

    void Update() {

        //BoardController.Instance

        displayBank.text = BoardController.Instance.board.bankGold.NumOfGems.ToString();
        displayBank = GameObject.Find("Canvas/Bank_Panel/GoldPile/Text").GetComponent<Text>();
        displayPurchase.text = BoardController.Instance.board.tempGold.NumOfGems.ToString(); 

    }


}
