using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class uiscore : MonoBehaviour {
    public Text scoretxt;
    public int finalscr;
    public int bestscr;
    public Text besttxt;
    public Text record;
    // Use this for initialization
    void Start () {
        finalscr = PlayerPrefs.GetInt("pscr");
        scoretxt.text = "Score : " + finalscr;
        bestscr = PlayerPrefs.GetInt("bscr");
        besttxt.text = "Best : " + bestscr;


        if (bestscr > finalscr)
            record.text = "";
        else
            record.text = "COOL!! NEW BEST!";

    }

    // Update is called once per frame
    void Update () {
	
	}
}
