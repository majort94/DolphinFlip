using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour {

	public GameObject loadingScreen;
	public bool loadScreen = true;

	public void LoadScene(int level)
	{
		if (loadScreen)
		{
			loadingScreen.SetActive(true);
		}
		if (level == 1) {
			loadScreen = false;
		}
		SceneManager.LoadScene(level);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) {
			LoadScene (1);

		}
	
	}
}
