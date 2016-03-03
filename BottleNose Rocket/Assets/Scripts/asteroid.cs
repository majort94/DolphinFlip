using UnityEngine;
using System.Collections;

public class asteroid : MonoBehaviour {

	private Vector2 velocity;
	private Rigidbody2D rb;
	private float speed;
	private Transform transform;
	// Use this for initialization
	void Start () {
		//speed = Random.Range (2f, 10f);
		///rb = GetComponent<Rigidbody2D>();
		//rb.velocity = new Vector2 (-1 * speed, 0f);

		transform = GetComponent<Transform> ();
		float scale = Random.Range (.5f, 2f);
		transform.localScale = new Vector3 (scale, scale, scale);

	}

}
