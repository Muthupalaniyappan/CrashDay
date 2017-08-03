using UnityEngine;
using System.Collections;

public class enemydestroy : MonoBehaviour {

    
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D (Collision2D col)
	{
        //Application.LoadLevel("2");
        
       // Destroy(col.gameObject);
	}
}
