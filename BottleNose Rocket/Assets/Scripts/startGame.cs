using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startGame : MonoBehaviour {

	public GameObject loadingScreen;
	public bool loadScreen = true;
	private float timestamp = -5;
	private int level;
	public GameObject t;

	public void Start(){
		//loadingScreen = GameObject.Find ("/Canvas/Window/loading");
	}

	public void LoadScene(int level)
	{	this.level = level;
		if (loadScreen)
		{
			timestamp = Time.timeSinceLevelLoad;
			loadingScreen.SetActive(true);
		}
		if (level == 1) {
			loadScreen = false;
		}
		if (Time.timeSinceLevelLoad > (timestamp + 0.1f)) {
			SceneManager.LoadScene (level);
			t.SetActive (true);
		}

	}
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) {
			LoadScene (1);

		}
	
	}
}
