using UnityEngine;
using System.Collections;

public class sound : MonoBehaviour {
    private AudioSource collisionaudio;
    public AudioClip crashaudio;
    // Use this for initialization
    void Start () {

        collisionaudio = gameObject.AddComponent<AudioSource>();
        collisionaudio.clip = crashaudio;
        collisionaudio.loop = false;
        collisionaudio.volume = 1.0f;
        collisionaudio.Play();

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
