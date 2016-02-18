using UnityEngine;
using System.Collections;

public class hoop : MonoBehaviour {

	public Rigidbody2D rocketBody;
	public Rigidbody2D dolphinBody;
	public GameObject rocket;
	public GameObject dolphin;
	public GameObject bird;
	private Transform hoopTransform;
	private int rotateX;
	private int rotateY;
	private int rotateZ;


	// Use this for initialization
	void Start () {
		hoopTransform = GetComponent<Transform> ();
		rotateX = 0;
		rotateY = 0;
		rotateZ = 0;

	}

	void OnTriggerEnter2D(Collider2D temp){
		//Debug.Log ("Hoop, " + temp.gameObject);
		if (temp.gameObject == dolphin) {
			rocketBody.AddForce (new Vector2 (.5f, 1) * rocket.GetComponent<rocket> ().thrust, ForceMode2D.Impulse);
			dolphinBody.AddForce (new Vector2 (.5f, 1) * rocket.GetComponent<rocket> ().thrust, ForceMode2D.Impulse);
		Debug.Log ("Hoop, " + temp.gameObject);
		}
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		rotateX -= 0;
		rotateY -= 2;
		rotateZ -= 2;

		hoopTransform.rotation = Quaternion.Euler (rotateX, rotateY, rotateZ);
	}


		
}
