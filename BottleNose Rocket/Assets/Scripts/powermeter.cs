using UnityEngine;
using System.Collections;

public class powermeter : MonoBehaviour {

    public bool looping = true;
    int switchRotate = 1;


	void Start () {
	    
	}
	
	void Update () {
	    if (looping)
        {
            if (transform.rotation.z < -0.41f)
            {
                switchRotate = -1;
            }
            if (transform.rotation.z > 0.41f)
            {
                switchRotate = 1;
            }
            transform.Rotate(Vector3.forward * (-1) * switchRotate * (4f -  8f * Mathf.Abs(transform.rotation.z)));
        }
	}
}
