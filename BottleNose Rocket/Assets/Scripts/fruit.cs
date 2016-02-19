using UnityEngine;
using System.Collections;

public class fruit : MonoBehaviour {

    public int reward;

    //References
    public GameObject dolphin;

	void Start () {
        dolphin = GameObject.Find("dolphin");
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == dolphin)
        {
            //increase score
            dolphin.GetComponent<dolphin>().fruitBonus += reward;
			dolphin.GetComponent<dolphin> ().setScore ();
            //destroy self
			Destroy (gameObject);
        }
    }
}
