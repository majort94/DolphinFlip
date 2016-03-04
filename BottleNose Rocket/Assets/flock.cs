using UnityEngine;
using System.Collections;

public class flock : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == GameObject.Find("dolphin"))
		{
			//increase score
			GameObject.Find("dolphin").GetComponent<dolphin>().onHit();
			GameObject.Find ("GameManager").GetComponent<InputManager> ().onHit ();

			GetComponent<AudioSource>().Play();
		}
	}
}
