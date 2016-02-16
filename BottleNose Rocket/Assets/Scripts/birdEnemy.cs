using UnityEngine;
using System.Collections;

public class birdEnemy : MonoBehaviour {

	private Vector2 velocity;
	private Rigidbody2D rb;
	private float thrust;
	// Use this for initialization
	void Start () {
		thrust = Random.Range (.5f, 1f);
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce (Vector2.left * thrust * Time.fixedDeltaTime, ForceMode2D.Impulse);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
