using UnityEngine;
using System.Collections;

public class obstacleSoundTrigger : MonoBehaviour {

    bool played = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (played == false)
        {
            GetComponent<AudioSource>().Play();
            played = true;
        }
    }
}
