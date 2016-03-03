using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour {

    public GameObject powerMeter;

	public Rigidbody2D rocketBody;
	public Rigidbody2D dolphinBody;
	public int clicks;
	public Text clickText;
	public GameObject rocket;
	public Camera camera1;
	public GameObject dolphin;

	private bool debug = false;

	private bool inAir = false;

	private bool beenTouched = false;
	private float particleTimeStamp = 0f;
	public ParticleSystem smoke;
	public ParticleSystem smoke2;
	public GameObject fire;
	public GameObject pause;


	public bool gameOver = false;


	public Text rotation;

	// Use this for initialization
	void Start () {
		clicks = 10;
		if (debug) {
			clicks = 100;
		}
	}
	public void onHit(){
		clicks = 0;
		clickText.text = clicks + " clicks remaining";
	}
	public void onRocket(){
		clicks++;
		clickText.text = clicks + " clicks remaining";
		//gameOver = false;
	}
	
	// Update is called once per frame
	//void FixedUpdate(){
		//resetTouch ();
		//if (((Input.GetMouseButtonUp (0)) || ((Input.touchCount > 0)  && Input.GetTouch( 0 ).phase == TouchPhase.Began )) && (clicks > 0) && !beenTouched) {
			
	void boost(Vector2 direction){
			
			//beenTouched = true;
			clicks--;
			clickText.text = clicks + " clicks remaining";

			rocketBody.gravityScale = .3f;
			dolphinBody.gravityScale = .3f;


			// while in the air

			if (inAir) {

				//Vector3 p = camera.ScreenToWorldPoint(new Vector3(100, 100, camera.nearClipPlane));

				//Debug.Log ("dir: " + direction);

				//rocketBody.AddForce (Vector2.Scale(new Vector2 (1, 1), direction) * rocket.GetComponent<rocket> ().thrust, ForceMode2D.Impulse);
				//dolphin.AddForce (Vector2.Scale(new Vector2 (1, 1), direction) * rocket.GetComponent<rocket> ().thrust, ForceMode2D.Impulse);
				if (dolphin.GetComponent<Rigidbody2D> ().velocity.y < 0) {
					dolphin.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
					rocketBody.velocity = Vector2.zero;
				}
				rocketBody.AddForce (direction * rocket.GetComponent<rocket> ().thrust, ForceMode2D.Impulse);
				dolphinBody.AddForce ( direction * rocket.GetComponent<rocket> ().thrust, ForceMode2D.Impulse);
			} else {
                powerMeter.GetComponent<powermeter>().looping = false;
                float ratio = 1.5f - Mathf.Abs(powerMeter.transform.rotation.z);
				rocketBody.AddForce (new Vector2 (.7f, 1) * rocket.GetComponent<rocket> ().thrust * ratio, ForceMode2D.Impulse);
				dolphinBody.AddForce (new Vector2 (.7f, 1) * rocket.GetComponent<rocket> ().thrust * ratio, ForceMode2D.Impulse);
			}
		fire.SetActive (true);
		smoke.Play ();
		smoke2.Play ();
		particleTimeStamp = Time.timeSinceLevelLoad;

		dolphin.GetComponent<dolphin> ().gameStart = true;
			inAir = true;
		//}
	
	}


	void Update(){
		float rotationAngle = Mathf.Rad2Deg * Mathf.Atan2(Input.acceleration.y, Mathf.Abs(Input.acceleration.x)); 
		//rotation.text = "rotation: " + rotationAngle;


		if ((((Input.touchCount > 0) && Input.GetTouch (0).phase == TouchPhase.Began)) && ((clicks > 0) || gameOver)) {

			if (gameOver) {
				this.GetComponent<UILoadLevel> ().LoadScene (1);
				dolphin.GetComponent<dolphin> ().gameStart = false;
			}
			Vector3 mousePos;//camera1.ScreenToWorldPoint (Input.mousePosition);
			//Touch[] touches = Input.touches;
			Vector2 mousePos2D;
			Vector2 direction;
			if (Input.touches.Length > 0) {
				if (Input.touchCount > 1) {
					Time.timeScale = 0;
					pause.SetActive (true);
					return;
				}
				if (Time.timeScale == 0) {
					pause.SetActive(false);
					Time.timeScale = 1;
					return;
				}
				mousePos = camera1.ScreenToWorldPoint (Input.touches [0].position);
				mousePos2D = new Vector2 (mousePos.x, mousePos.y);
				direction = mousePos2D - dolphinBody.position;
				direction.Normalize ();
				boost (direction);
			}
		}

		resetParticles ();

	}

	void resetParticles(){
		if ((Time.timeSinceLevelLoad > (particleTimeStamp + .5f)) && (particleTimeStamp != 0)) {
			smoke.Pause ();
			smoke2.Pause ();
			fire.SetActive (false);
			//smoke.Clear ();
			//smoke2.Clear ();
		}
	}


}
