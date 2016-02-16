using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour {

	// Use this for initialization
	void Start () {
		QualitySettings.antiAliasing = 0;
		QualitySettings.shadowCascades = 0;
		QualitySettings.shadowDistance = 15;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
