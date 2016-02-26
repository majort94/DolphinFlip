using UnityEngine;
using System.Collections;

public class splashTrigger : MonoBehaviour {

    bool played = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if ((transform.position.y <= 0) && (played == false))
        {
            GetComponent<AudioSource>().Play();
            played = true;
        }
	}
}
