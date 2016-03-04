using UnityEngine;
using System.Collections;

public class star : MonoBehaviour {

	private SpriteRenderer render;
	private bool down = true;
	private float alpha = 1f;
	Vector4 color;
	// Use this for initialization
	void Start () {
		render = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<Transform>().position.y > (GameObject.Find("dolphin").GetComponent<Transform> ().position.y + 20)) {
			return;
		}
		if (down) {
			alpha -= .05f;
			color = new Vector4 (1f, 1f, 1f, alpha);
			render.color = color;
			if (alpha <= 0f) {
				down = false;
			}
		} else {
			if (!down) {
				alpha += .05f;
				color = new Vector4 (1f, 1f, 1f, alpha);
				render.color = color;
				if (alpha >= 1f) {
					down = true;
				}
			}
		
		}


		if (((GetComponent<Transform> ().position.x < (GameObject.Find ("dolphin").GetComponent<Transform>().position.x - 40)) && (GetComponent<Transform> ().position.y < (GameObject.Find ("dolphin").GetComponent<Transform>().position.y + 30)) ) || ((GetComponent<Transform> ().position.x > (GameObject.Find ("dolphin").GetComponent<Transform>().position.x + 400)))) {
			if (GameObject.Find ("dolphin").GetComponent<dolphin>().loopReady) {
				GetComponent<Transform> ().position = new Vector3 (GameObject.Find ("dolphin").GetComponent<Transform>().position.x + 40, GetComponent<Transform> ().position.y, GetComponent<Transform> ().position.z);
			}
		}
	}
}
