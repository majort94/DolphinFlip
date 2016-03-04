using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UILoadLevel : MonoBehaviour
{
    public GameObject loadingScreen;
    public bool loadScreen = true;
	private float timestamp = -5;
	private int level;

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
			if (Time.timeSinceLevelLoad > (timestamp + 2f)) {
				SceneManager.LoadScene (level);
			}

    }

}