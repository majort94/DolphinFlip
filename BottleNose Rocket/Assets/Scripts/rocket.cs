using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class rocket : MonoBehaviour {


	public float thrustUp = 7000f;
	public Rigidbody2D rb;
	public Rigidbody2D dolphin;
	public int clicks;
	public Text text;

	// Use this for initialization
	void Start () {
		clicks = 3;
		rb = GetComponent<Rigidbody2D>();
	}

	public void onHit(){
		clicks = 0;
		text.text = clicks + " clicks remaining";
	}
	// Update is called once per frame
	void Update () {
		if ((Input.GetMouseButtonDown (0)) && (clicks > 0)) {
			clicks--;
			text.text = clicks + " clicks remaining";

			rb.gravityScale = .5f;
			dolphin.gravityScale = .5f;

			rb.AddForce (new Vector2(.7f,1) * thrustUp, ForceMode2D.Impulse);
			dolphin.AddForce (new Vector2(.7f,1) * thrustUp, ForceMode2D.Impulse);
		}
	
	}


		
}
