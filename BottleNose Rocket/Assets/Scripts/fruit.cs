using UnityEngine;
using System.Collections;

public class fruit : MonoBehaviour {

    public int reward;

    //References
    public GameObject dolphin;

	void Start () {
        dolphin = GameObject.Find("dolphin");
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == dolphin)
        {
            //increase score
            dolphin.GetComponent<dolphin>().fruitBonus += reward;
            //destroy self
            Destroy (gameObject);
        }
    }
}
