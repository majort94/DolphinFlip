using UnityEngine;
using System.Collections;

public class birdEnemy : MonoBehaviour {

	private Vector2 velocity;
	private Rigidbody2D rb;
	private float speed;
	public bool isFlock = false;
	// Use this for initialization
	void Start () {
		//speed = Random.Range (2f, 10f);
		if (isFlock) {
			rb.velocity = new Vector2 (-2f, 0f);
		}
	}
	

}
