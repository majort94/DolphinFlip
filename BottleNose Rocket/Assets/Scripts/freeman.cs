using UnityEngine;
using System.Collections;

public class freeman : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if ((GetComponent<Transform> ().position.x < (GameObject.Find ("dolphin").GetComponent<Transform>().position.x - 40)) || ((GetComponent<Transform> ().position.x > (GameObject.Find ("dolphin").GetComponent<Transform>().position.x + 400)))) {
			if (GameObject.Find ("dolphin").GetComponent<dolphin>().loopReady) {
				GetComponent<Transform> ().position = new Vector3 (GameObject.Find ("dolphin").GetComponent<Transform>().position.x + 40, GetComponent<Transform> ().position.y, GetComponent<Transform> ().position.z);
			}
		}

	}
}
