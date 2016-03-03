using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class rocket : MonoBehaviour {


	public float thrust = 300f;
	public bool inAir = false;
	private Rigidbody2D rb;
	private bool waddle = true;
	private Transform transform;
	private GameObject dolphin;
	private float timeSet = -1f;

	// Use this for initialization
	void Start () {
		dolphin = GameObject.Find ("dolphin");
		rb = GetComponent<Rigidbody2D> ();
		transform = GetComponent<Transform> ();
		if (inAir) {
			//rb.velocity = new Vector2 (-1, -1);
			GetComponent<Transform>().rotation =  Quaternion.Euler (0, 0, 217f);
		}
		timeSet = Time.timeSinceLevelLoad;
	}
		
	// Update is called once per frame
	void FixedUpdate () {
		if (inAir) {
			if (((transform.position.x < (dolphin.GetComponent<Transform> ().position.x + 20)) && (transform.position.x > (dolphin.GetComponent<Transform> ().position.x - 20))) && ((transform.position.y < (dolphin.GetComponent<Transform> ().position.y + 20) && (transform.position.y > (dolphin.GetComponent<Transform> ().position.y - 20))))) {
				{
					
					if (waddle) {
						//rb.velocity = new Vector2 (rb.velocity.x + .1f, -1f);
						transform.position = new Vector3(transform.position.x - .05f, transform.position.y, transform.position.z);
						if (Time.timeSinceLevelLoad > (timeSet + 5f)) {
							waddle = false;
							timeSet = Time.timeSinceLevelLoad;

						}
					} else {
						transform.position = new Vector3(transform.position.x + .05f, transform.position.y, transform.position.z);
						if (Time.timeSinceLevelLoad > (timeSet + 5f)) {
							waddle = true;
						}
					}
				}
			}
		}
		if ((GetComponent<Transform> ().position.x < (GameObject.Find ("dolphin").GetComponent<Transform>().position.x - 40)) || ((GetComponent<Transform> ().position.x > (GameObject.Find ("dolphin").GetComponent<Transform>().position.x + 400)))) {
			if (dolphin.GetComponent<dolphin>().loopReady) {
				GetComponent<Transform> ().position = new Vector3 (GameObject.Find ("dolphin").GetComponent<Transform>().position.x + 40, GetComponent<Transform> ().position.y, GetComponent<Transform> ().position.z);
			}
		}
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == GameObject.Find("dolphin"))
		{
			//increase lives
			GameObject.Find("GameManager").GetComponent<InputManager>().onRocket();
			//destroy self
			Destroy (gameObject);
		}
	}




		
}
