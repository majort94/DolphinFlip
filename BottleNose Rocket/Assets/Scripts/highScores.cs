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
    
	void Start () {
        //Set References
        int score = (int)dolphin.GetComponent<dolphin>().score;
        int[] highScores = new int[5];
        GameObject[] scoreObjects = { score1Object, score2Object, score3Object, score4Object, score5Object };

        //Defaults
        for (int i = 0; i < 5; i++)
        {
            if (PlayerPrefs.HasKey("Score" + i.ToString()))
            {
                highScores[i] = PlayerPrefs.GetInt("Score" + i.ToString());
                scoreObjects[i].GetComponent<Text>().text = highScores[i].ToString();
            }
            else
            {
                highScores[i] = 0;
                scoreObjects[i].GetComponent<Text>().text = highScores[i].ToString();
                PlayerPrefs.SetInt("Score" + i.ToString(), highScores[i]);
            }
        }

        // check if new high score, and if so then place in respective rank
        for (int i = highScores.Length; i >= 0; i--)
        {
            if (score > highScores[i - 1])
            {
                if (i != 1)
                {
                    if (!(score > highScores[i - 2]))
                    {
                        scoreObjects[i].GetComponent<Text>().text = score.ToString();
                        PlayerPrefs.SetInt("Score" + i.ToString(), score);
                    }
                }
                else
                {
                    scoreObjects[i].GetComponent<Text>().text = score.ToString();
                    PlayerPrefs.SetInt("Score" + i.ToString(), score);
                }
            }
        }


	}


}
