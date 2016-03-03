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
        int[] highScores = { PlayerPrefs.GetInt("Score1"), PlayerPrefs.GetInt("Score2"), PlayerPrefs.GetInt("Score3"), PlayerPrefs.GetInt("Score4"), PlayerPrefs.GetInt("Score5") };
        GameObject[] scoreObjects = { score1Object, score2Object, score3Object, score4Object, score5Object };

        // check if new high score, and if so then place in respective rank
        for (int i = 0; i < 5; i++) {
            if (score > highScores[i]) {
                if (highScores[i + 1] != null) {
                    if (!(score > highScores[i + 1])) {
                        scoreObjects[i].GetComponent<Text>().text = score.ToString();
                        PlayerPrefs.SetInt("Score" + i.ToString(), score);
                    }
                }
                else {
                    scoreObjects[i].GetComponent<Text>().text = score.ToString();
                    PlayerPrefs.SetInt("Score" + i.ToString(), score);
                }
            }
            else {
                scoreObjects[i].GetComponent<Text>().text = highScores[i].ToString();
            }
        }


	}


}
