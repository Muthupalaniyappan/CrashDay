



using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class carcontrol : MonoBehaviour {
	public float carspeed;
	Vector3 position;
	public float maxpos=3.2f;
	public uimanager ui;
    
    public AudioClip drive;
	private AudioSource driveaudio;
	Rigidbody2D rb;
	public float velocity;
	bool currentandroid=false;
    public int best;





	// Use this for initialization
	void Start () {
		#if UNITY_ANDROID
		currentandroid=true;
		#else
		currentandroid=false;
		#endif
		rb=GetComponent<Rigidbody2D>();
       
        driveaudio =gameObject.AddComponent<AudioSource>();
		driveaudio.clip=drive;
		driveaudio.loop=true;
		driveaudio.volume=1.0f;
		driveaudio.Play ();
        
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        bests();
        //transform.position =new Vector3 (Mathf.Clamp(Time.time,-1.0f,1.0f),0,0);

        if (currentandroid == true)
        {
            touchmove();
        }

        //position.x += Input.GetAxis("Horizontal") * carspeed * Time.deltaTime;
        position = transform.position;
        position.x = Mathf.Clamp(position.x, -1.2f, 1.2f);

        transform.position = position;
    }

	void OnCollisionEnter2D (Collision2D col)
	{
        PlayerPrefs.SetInt("pscr", uimanager.score);
        PlayerPrefs.Save();
        Application.LoadLevel("2");
        Destroy(gameObject);
        Destroy(col.gameObject);   
        //AudioSource.PlayClipAtPoint(collisionaudio.clip, transform.position);
        
    }

	void touchmove()
	{
        //transform.position = new Vector3(Mathf.Clamp(Time.time, -1.0f, 1.0f), 0, 0);
        if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch (0);
			float middle = Screen.width / 2;
			if (touch.position.x < middle && touch.phase == TouchPhase.Began) {
				moveleft ();
			}
			if (touch.position.x > middle && touch.phase == TouchPhase.Began) {
				moveright ();
			}
		} else {
			setvelocityzero ();
		}
	}
			
	public void moveleft(){
	rb.velocity=new Vector2(-carspeed,0f);

}
	public void moveright()
	{
		rb.velocity= new Vector2(carspeed,0f);
	}
	public void setvelocityzero()
	{
		rb.velocity=new Vector2(0f,0f);
	}


    void bests()
    {

        best = PlayerPrefs.GetInt("bscr");

        if (best < uimanager.score)
        {
            PlayerPrefs.SetInt("bscr", uimanager.score);

        }

    }
}