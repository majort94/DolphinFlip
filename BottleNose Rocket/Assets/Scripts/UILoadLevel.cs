using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UILoadLevel : MonoBehaviour
{
    public GameObject loadingScreen;
    public bool loadScreen = false;


	public void Start(){
		//loadingScreen = GameObject.Find ("/Canvas/Window/loading");
	}

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

}