using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class highScores : MonoBehaviour {

    public GameObject dolphin;
    //Children
    public GameObject score1Object;
    public GameObject score2Object;
    public GameObject score3Object;
    public GameObject score4Object;
    public GameObject score5Object;
	//References
	int score;
	int[] highScoreList = new int[5];
	GameObject[] scoreObjects;

	void Start () {
		//Set References
		score = (int)dolphin.GetComponent<dolphin>().score;
		scoreObjects = new GameObject[5];
		scoreObjects [0] = score1Object; // = { score1Object, score2Object, score3Object, score4Object, score5Object }; 
		scoreObjects [1] = score2Object;
		scoreObjects [2] = score3Object;
		scoreObjects [3] = score4Object;
		scoreObjects [4] = score5Object;

        //Defaults
        for (int i = 0; i < 5; i++)
        {
			if (PlayerPrefs.HasKey("Score" + (i+1).ToString()))
            {
				highScoreList[i] = PlayerPrefs.GetInt("Score" + (i+1).ToString());
                scoreObjects[i].GetComponent<Text>().text = highScoreList[i].ToString();
            }
            else
            {
                highScoreList[i] = 0;
                scoreObjects[i].GetComponent<Text>().text = highScoreList[i].ToString();
				PlayerPrefs.SetInt("Score" + (i+1).ToString(), 0);
            }
        }

        // check if new high score, and if so then place in respective rank
        for (int i = 5; i > 0; i--)
        {
            if (score > highScoreList[i - 1])
            {
                if (i > 1)
                {
                    if (score < highScoreList[i - 2])
                    {
						//highScoreList[i - 1] = score;
                        //scoreObjects[i - 1].GetComponent<Text>().text = score.ToString();
                        //PlayerPrefs.SetInt("Score" + i.ToString(), score);

						shiftDown (i);
						return;
                    }
                }
                else
                {
					shiftDown (i);
					return;
                }
            }
        }


	}

	void shiftDown(int index)
	{
		int tempScore = 0;

		for (int i = 5; i >= index; i--) {
			
			if (i == index) {
				highScoreList [i - 1] = score;
				scoreObjects [i - 1].GetComponent<Text> ().text = score.ToString ();
				PlayerPrefs.SetInt ("Score" + i.ToString (), score);
			} else {
				highScoreList [i - 1] = highScoreList [i - 2];
				scoreObjects [i - 1].GetComponent<Text> ().text = highScoreList [i - 2].ToString ();
				PlayerPrefs.SetInt ("Score" + i.ToString (), highScoreList [i - 2]);
			}
		}


	}
}
