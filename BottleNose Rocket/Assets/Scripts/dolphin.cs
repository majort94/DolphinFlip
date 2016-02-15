using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dolphin : MonoBehaviour {
	private Transform tr;
	public Rigidbody2D rocket;
	public Rigidbody2D rb;
	public float thrust = 2f;
	private bool underSea = false;
	public Transform camera;
	public Transform canvas;
	private Vector3 camVect;
	private Vector3 canvasVect;
	public float floor = -6.5f;

	public GameObject rocketObj;



	private float score = 0;
	private float maxHeight = 0f;
	public Text scoreText;

	private int lives = 1;



	// Use this for initialization
	void Start () {
		tr = GetComponent<Transform>();
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (tr.position.y > maxHeight) {
			maxHeight = tr.position.y;
			score = maxHeight * 3.5f;
			scoreText.text = "Score: " + (int) score;

		}

		camVect = new Vector3(tr.position.x,tr.position.y,-10);
		canvasVect = new Vector3(tr.position.x,tr.position.y,0);
		camera.position = camVect;
		canvas.position = canvasVect;
		if ((tr.position.y < 0) && (!underSea)) {
			underSea = true;
			rb.gravityScale = 0;
			rocket.gravityScale = 0;
			Vector2 temp = new Vector2 (rb.velocity.x * .1f, rb.velocity.y * .1f);
			rb.velocity = temp;
			rocket.velocity = temp;
		} else {
			if ((tr.position.y > 0) && (underSea)) {
				underSea = false;
			}
		}

		if (tr.position.y < floor) {
			rb.velocity = Vector2.zero;
			rocket.velocity = Vector2.zero;
		}
	}

	public void onHit(){
		Vector2 temp;
		if (rb.velocity.y > 0) {
			temp = new Vector2 (rb.velocity.x * .1f, rb.velocity.y * -.1f);
		} else {
			temp = new Vector2 (rb.velocity.x * .05f, rb.velocity.y * .1f);
		}
		rb.velocity = temp;
		//rocket.velocity = temp;

	}



}
