using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
* Game Handler Class.
* In charge of managing the game's functionalities.
**/
public class GameHandler: MonoBehaviour {
    public int points = 0;
    public int maxSpeed;
    public GameObject pointsObject;
    public GameObject sfx;
    public GameObject gameOver;
    public GameObject backScript;
    public GameObject replay;
    public GameObject backToMenu;
    public Player player;

    /** Initialize the variables. **/ 
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        replay.SetActive(false);
        backToMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
    }

    /** Reset points. **/ 
    public void resetGame() {
        points = 0;
        updatePoints();
    }

    /** Add points. **/ 
    public void addPoints() {
        playSFX(2);
        points += 1;
        updatePoints();

        if (points % 2 == 0 && player.velocityX < maxSpeed) {
            player.velocityX += player.increasedSpeed;
        }
    }

    /** Get the text to modify and update the points. **/ 
    public void updatePoints() {
        PlayerPrefs.SetInt("Points", points);
        pointsObject.GetComponent<Text>().text = points.ToString();
    }

    /** Play the audio. **/ 
    public void playSFX(int number) {
        sfx.GetComponent<SFX>().play(number);
    }

    /** Detect death. **/
    public void lost() {
        backScript.GetComponent<Background>().enabled = false;
        gameOver.SetActive(true);
    }

    /** Initialize points to zero. **/
    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad() {
        PlayerPrefs.SetInt("Points", 0);
    }
}
