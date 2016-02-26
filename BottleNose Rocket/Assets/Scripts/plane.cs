using UnityEngine;
using System.Collections;

public class plane : MonoBehaviour {

	private Vector2 velocity;
	private Rigidbody2D rb;
	private float speed;
	// Use this for initialization
	void Start () {
		speed = Random.Range (2f, 10f);
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2 (-1 * speed, 0f);
		//rb.AddForce (Vector2.left * thrust, ForceMode2D.Impulse);

	}

	// Update is called once per frame
	void Update () {
		if (GetComponent<Transform> ().position.x < 170) {
			if (GameObject.Find ("dolphin").GetComponent<dolphin>().loopReady) {
				GetComponent<Transform> ().position = new Vector3 (900, GetComponent<Transform> ().position.y, GetComponent<Transform> ().position.z);
			}
		}

	}
}
