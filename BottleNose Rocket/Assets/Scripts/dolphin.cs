using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dolphin : MonoBehaviour {
	private Transform dolphinTransform;
	public Rigidbody2D rocket;
	public Rigidbody2D rb;
	public float thrust = 2f;
	private bool underSea = false;
	public Transform camera1;
	public Transform canvas;
	private Vector3 camVect;
	private Vector3 canvasVect;
	public float floor = -6.5f;

	public bool gameStart = false;

	public GameObject rocketObj;
	public GameObject manager;




	private float score = 0;
	private float maxHeight = 0f;
	public Text scoreText;
	public GameObject gameOver;

//	private int lives = 1;



	// Use this for initialization
	void Start () {
		dolphinTransform = GetComponent<Transform>();
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate(){

		if(gameStart){
			if (dolphinTransform.position.y > maxHeight) {
				maxHeight = dolphinTransform.position.y;
				score = maxHeight * 3.5f;
				scoreText.text = "Score: " + (int) score;

			}
			if ((dolphinTransform.position.y < 0) && (!underSea)) {
				underSea = true;
				rb.gravityScale = .3f;
				rocket.gravityScale = .3f;
				Vector2 temp = new Vector2 (rb.velocity.x * .1f , rb.velocity.y * .1f);
				rb.velocity = temp  * Time.fixedDeltaTime;
				rocket.velocity = temp  * Time.fixedDeltaTime;
			} else {
				if ((dolphinTransform.position.y > 0) && (underSea)) {
					//underSea = false;
				}
			}

			if (dolphinTransform.position.y <= floor) {
				rb.velocity = Vector2.zero;
				rocket.velocity = Vector2.zero;
				gameOver.SetActive (true);
				manager.GetComponent<InputManager> ().gameOver = true;
			}


		}


		camVect = new Vector3(dolphinTransform.position.x,dolphinTransform.position.y,-10);
		canvasVect = new Vector3(dolphinTransform.position.x,dolphinTransform.position.y,0);
		camera1.position = camVect;
		canvas.position = canvasVect;
		camera1.rotation = Quaternion.Euler (0.0f, 0.0f, 0.0f);
		canvas.rotation = Quaternion.Euler (0.0f, 0.0f, 0.0f);

	}

	public void onHit(){
		Vector2 temp;
		if (rb.velocity.y > 0) {
			temp = new Vector2 (rb.velocity.x * .1f, rb.velocity.y * -.1f);
		} else {
			temp = new Vector2 (rb.velocity.x * .05f, rb.velocity.y * .1f);
		}
		rb.velocity = temp  * Time.fixedDeltaTime;
		//rocket.velocity = temp;

	}



}
