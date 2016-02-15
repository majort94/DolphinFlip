using UnityEngine;
using System.Collections;

public class obstacles : MonoBehaviour {

	public GameObject bird;
	public int numBirds;


	// Use this for initialization
	void Start () {
		for (int i = 0; i < numBirds; i++) {
			float randX = Random.Range (3f, 200f);
			float randY = Random.Range (3f, 80f);
			Vector2 pos = new Vector2 (randX, randY);
			Instantiate (bird, pos, Quaternion.identity);
		}
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
