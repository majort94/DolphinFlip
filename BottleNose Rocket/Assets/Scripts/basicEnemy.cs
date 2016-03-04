using UnityEngine;
using System.Collections;

public class basicEnemy : MonoBehaviour {

	private Vector2 velocity;
	//private Rigidbody2D rb;
	private float speed;
	private GameObject dolphin;
	private GameObject manager;
	private bool isHit = false;
	private Transform transform;
	public Sprite sprite;
	// Use this for initialization
	void Start () {
		speed = Random.Range (0.05f, .3f);
		transform = GetComponent<Transform> ();
		//Vector = new Vector2 (-1 * speed, 0f);
		dolphin = GameObject.Find ("dolphin");
		manager = GameObject.Find ("GameManager");

	}

	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position.y > (dolphin.GetComponent<Transform> ().position.y + 20)) {
			return;
		}
		if (!isHit) {
			transform.position = new Vector3 (transform.position.x - speed, transform.position.y, transform.position.z);
		} else {
			if (isHit) {
				transform.position = new Vector3 (transform.position.x + .05f, transform.position.y - .15f, transform.position.z);
			}

		}
		
		if (((GetComponent<Transform> ().position.x < (GameObject.Find ("dolphin").GetComponent<Transform>().position.x - 40)) && (GetComponent<Transform> ().position.y < (GameObject.Find ("dolphin").GetComponent<Transform>().position.y + 30)) ) || ((GetComponent<Transform> ().position.x > (GameObject.Find ("dolphin").GetComponent<Transform>().position.x + 400)))) {
			if (dolphin.GetComponent<dolphin>().loopReady) {
				GetComponent<Transform> ().position = new Vector3 (GameObject.Find ("dolphin").GetComponent<Transform>().position.x + 40, GetComponent<Transform> ().position.y, GetComponent<Transform> ().position.z);
			}
		}

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == dolphin)
		{
			//increase score
			dolphin.GetComponent<dolphin>().onHit();
			manager.GetComponent<InputManager> ().onHit ();
			isHit = true;
			if (GetComponent<AudioSource> () != null) {
				GetComponent<AudioSource> ().Play ();
			}
			if (sprite != null) {
				GetComponent<SpriteRenderer> ().sprite = sprite;
			} 
		}
	}
}
