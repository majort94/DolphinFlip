using UnityEngine;
using System.Collections;

public class cloud : MonoBehaviour {

	private Vector2 velocity;
	private Rigidbody2D rb;
	private float speed;
	private GameObject dolphin;
	// Use this for initialization
	void Start () {
		speed = Random.Range (2f, 10f);
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2 (-1 * speed, 0f);
		//rb.AddForce (Vector2.left * thrust, ForceMode2D.Impulse);
		dolphin = GameObject.Find("dolphin");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if ((GetComponent<Transform> ().position.x < (GameObject.Find ("dolphin").GetComponent<Transform>().position.x - 40)) || ((GetComponent<Transform> ().position.x > (GameObject.Find ("dolphin").GetComponent<Transform>().position.x + 400)))) {
			if (GameObject.Find ("dolphin").GetComponent<dolphin>().loopReady) {
				GetComponent<Transform> ().position = new Vector3 (GameObject.Find ("dolphin").GetComponent<Transform>().position.x + 40, GetComponent<Transform> ().position.y, GetComponent<Transform> ().position.z);
			}
		}

	}
}
