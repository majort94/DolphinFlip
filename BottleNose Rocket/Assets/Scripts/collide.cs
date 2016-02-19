using UnityEngine;
using System.Collections;

public class collide : MonoBehaviour {

	public GameObject dolphin;
	public GameObject rocket;
	public Rigidbody2D rocketBody;
	public Rigidbody2D dolphinBody;
//	private Transform tr;
	//public Rigidbody2D rb;
	public GameObject gameManager;
	public GameObject hoop;
	public GameObject bird;
	public Transform camera1;
	public GameObject plane;

	private bool debug = true;

	public float floor = -6.5f;
	// Use this for initialization
	void Start () {
	//	tr = GetComponent<Transform>();
		//rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	/*
	 * void FixedUpdate(){
		if (tr.position.y < floor) {
			//rb.velocity = Vector2.zero;
		}
	}
*/
	void OnCollisionEnter2D(Collision2D temp){
		if (debug) {
			
		}
		if (temp.gameObject.GetType() == bird.GetType()) {
			dolphin.GetComponent<dolphin> ().onHit ();
			gameManager.GetComponent<InputManager> ().onHit ();
		}
		if (temp.gameObject.GetType() == plane.GetType()) {
			dolphin.GetComponent<dolphin> ().onHit ();
			gameManager.GetComponent<InputManager> ().onHit ();
		}

		camera1.rotation = Quaternion.Euler (0.0f, 0.0f, 0.0f);
	}

		



}
