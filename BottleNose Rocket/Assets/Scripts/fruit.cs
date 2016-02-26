using UnityEngine;
using System.Collections;

public class fruit : MonoBehaviour {

    public int reward;

    //References
    public GameObject dolphin;
	private Transform fruitTransform;

	void Start () {
        dolphin = GameObject.Find("dolphin");
		fruitTransform = GetComponent<Transform> ();
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

	public void loopClear(){
		if ((fruitTransform.position.x > 139) && (fruitTransform.position.x < 159)) {
			Destroy (gameObject);
		}
	}
}
