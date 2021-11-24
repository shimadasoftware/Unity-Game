using UnityEngine;
using UnityEngine.UI;

/**
* Highest Scores Class.
* In charge of managing the maximum score achieved.
**/
public class HighestScores: MonoBehaviour {
    public Text score;
    public Text highScore;
    public GameHandler gameHandler;
    
    /** Update the maximum score achieved. **/ 
    void Start() {
        int points = PlayerPrefs.GetInt("Points", 0);
        int maxPoints = PlayerPrefs.GetInt("HighScore", 0);

        score.text = points.ToString();
        if (points > maxPoints) {
            PlayerPrefs.SetInt("HighScore", points);
            maxPoints = points;
        }

        highScore.text = maxPoints.ToString();
    }

    // Update is called once per frame
    void Update() {
    }
}
 