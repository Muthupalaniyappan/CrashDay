using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class uimanager : MonoBehaviour {

	public Button[] buttons;
	public Text scoreText;
    public Text final;
    public int finalscr;
	static public int score;
	// Use this for initialization
	void Start () {
		score = 0;
		InvokeRepeating ("scoreupdate", 1.0f, 0.5f);
	
	}

	
	// Update is called once per frame
	void Update () {
	
		scoreText.text = ""+ score;
	}

    void scoreupdate()
    {
        score += 1;
    }

    public void play()
	{
        Application.LoadLevel ("1");	
	}
	
	public void replay()
	{
        Application.LoadLevel ("1");
    }
	public void exit()
	{
		Application.Quit();
	}

    public void aboutas()
    {
        Application.LoadLevel ("3");
    }

    public void back()
    {
        Application.LoadLevel ("0");
    }

    public void next()
    {
        Application.LoadLevel ("4");
    }

}