using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputManager : MonoBehaviour {

	public Rigidbody2D rocketBody;
	public Rigidbody2D dolphinBody;
	public int clicks;
	public Text clickText;
	public GameObject rocket;
	public Camera camera;

	private bool debug = true;

	private bool inAir = false;

	// Use this for initialization
	void Start () {
		clicks = 3;
		if (debug) {
			clicks = 100;
		}
	}
	public void onHit(){
		clicks = 0;
		clickText.text = clicks + " clicks remaining";
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		if (((Input.GetMouseButtonDown (0)) || (Input.touchCount > 0)) && (clicks > 0)) {
			
			clicks--;
			clickText.text = clicks + " clicks remaining";

			rocketBody.gravityScale = .5f;
			dolphinBody.gravityScale = .5f;


			// while in the air

			if (inAir) {

				//Vector3 p = camera.ScreenToWorldPoint(new Vector3(100, 100, camera.nearClipPlane));
				Vector3 mousePos = camera.ScreenToWorldPoint (Input.mousePosition);
				//Touch[] touches = Input.touches;
				if (Input.touches.Length > 0) {
					mousePos = camera.ScreenToWorldPoint (Input.touches [0].position);
				}
				Vector2 mousePos2D = new Vector2 (mousePos.x, mousePos.y);
				Vector2 direction = mousePos2D - dolphinBody.position;
				direction.Normalize ();
				Debug.Log ("dir: " + direction);

				//rocketBody.AddForce (Vector2.Scale(new Vector2 (1, 1), direction) * rocket.GetComponent<rocket> ().thrust, ForceMode2D.Impulse);
				//dolphin.AddForce (Vector2.Scale(new Vector2 (1, 1), direction) * rocket.GetComponent<rocket> ().thrust, ForceMode2D.Impulse);

				rocketBody.AddForce (direction * rocket.GetComponent<rocket> ().thrust * Time.fixedDeltaTime, ForceMode2D.Impulse);
				dolphinBody.AddForce ( direction * rocket.GetComponent<rocket> ().thrust * Time.fixedDeltaTime, ForceMode2D.Impulse);
			} else {
				rocketBody.AddForce (new Vector2 (.7f, 1) * rocket.GetComponent<rocket> ().thrust * Time.fixedDeltaTime, ForceMode2D.Impulse);
				dolphinBody.AddForce (new Vector2 (.7f, 1) * rocket.GetComponent<rocket> ().thrust * Time.fixedDeltaTime, ForceMode2D.Impulse);
			}


			inAir = true;
		}
	
	}
}
