using UnityEngine;
using System.Collections;

public class carSpawner : MonoBehaviour  {

	public GameObject[] cars;
	public float maxPos = 5.75f;
	public float delaytime=1f;
	int carno;
	float timer;

	//use this for initialization
	void Start () {
		timer = delaytime;
	}

	// Update is called once per frame
	void Update ()
	{

		timer -= Time.deltaTime;
		if (timer <= 0) {

			Vector3 carPos = new Vector3 (Random.Range(-1f,1f), transform.position.y, transform.position.z);

			carno = Random.Range (0,5);
			Instantiate (cars[carno], carPos, transform.rotation);
			timer = delaytime;
		}


	}

}