using UnityEngine;
using System.Collections;

public class collide : MonoBehaviour {

	public GameObject dolphin;
	public GameObject rocketObj;
	private Transform tr;
	public Rigidbody2D rb;
	public float floor = -6.5f;
	// Use this for initialization
	void Start () {
		tr = GetComponent<Transform>();
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (tr.position.y < floor) {
			rb.velocity = Vector2.zero;
		}
	}

	void OnCollisionEnter2D(Collision2D temp){
		if (temp.gameObject == dolphin) {
			dolphin.GetComponent<dolphin> ().onHit ();
			rocketObj.GetComponent<rocket> ().onHit ();
		}
	}

}
