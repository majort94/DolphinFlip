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
			if (dolphin.GetComponent<Rigidbody2D> ().velocity.y < 0) {
				dolphin.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				rocket.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
			}
			rocketBody.AddForce (new Vector2 (.25f, 2f) * rocket.GetComponent<rocket> ().thrust, ForceMode2D.Impulse);
			dolphinBody.AddForce (new Vector2 (.25f, 2f) * rocket.GetComponent<rocket> ().thrust, ForceMode2D.Impulse);
		}
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		if(((hoopTransform.position.x < (dolphin.GetComponent<Transform>().position.x + 20)) && (hoopTransform.position.x > (dolphin.GetComponent<Transform>().position.x - 20))) && ((hoopTransform.position.y < (dolphin.GetComponent<Transform>().position.y + 20) && (hoopTransform.position.y > (dolphin.GetComponent<Transform>().position.y - 20))))){
		rotateX -= 0;
		rotateY -= 2;
		rotateZ -= 2;

		hoopTransform.rotation = Quaternion.Euler (rotateX, rotateY, rotateZ);
		}

		if ((GetComponent<Transform> ().position.x < (GameObject.Find ("dolphin").GetComponent<Transform>().position.x - 40)) || ((GetComponent<Transform> ().position.x > (GameObject.Find ("dolphin").GetComponent<Transform>().position.x + 400)))) {
			if (dolphin.GetComponent<dolphin>().loopReady) {
				GetComponent<Transform> ().position = new Vector3 (GameObject.Find ("dolphin").GetComponent<Transform>().position.x + 40, GetComponent<Transform> ().position.y, GetComponent<Transform> ().position.z);
			}
		}
	}

	public void loopClear(){
		if ((hoopTransform.position.x > 139) && (hoopTransform.position.x < 159)) {
			Destroy (gameObject);
		}
	}


		
}
