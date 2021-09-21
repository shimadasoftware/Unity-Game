using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler: MonoBehaviour {
    public int points = 0;
    public int maxSpeed;
    public GameObject pointsObject;
    public GameObject sfx;
    public GameObject gameOver;
    public GameObject backScript;
    public Player player;

    // Start is called before the first frame update
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void resetGame() {
        points = 0;
        updatePoints();
    }

    public void addPoints() {
        playSFX(2);
        points += 1;
        updatePoints();

        if (points % 2 == 0 && player.velocityX < maxSpeed) {
            player.velocityX += player.increasedSpeed;
        }
    }

    public void updatePoints() {
        pointsObject.GetComponent<Text>().text = points.ToString();
    }

    public void playSFX(int number) {
        sfx.GetComponent<SFX>().play(number);
    }

    public void lost() {
        backScript.GetComponent<Background>().enabled = false;
        gameOver.SetActive(true);
    }
}
