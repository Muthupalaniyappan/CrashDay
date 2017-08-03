using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class logo : MonoBehaviour {
	float delay = 2;
	// Use this for initializatio
	// Update is called once per frame



	void Update()
	{
		delay -= Time.deltaTime;
		if (delay <= 0)
			Application.LoadLevel("0");
	}


}
