using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* Player Class.
* In charge of managing the functionalities of a player.
**/
public class Player: MonoBehaviour {
    public float velocityX;
    public float increasedSpeed;
    public bool alive = true;
    public GameHandler gameHandler;
    public GameObject minimum;
    public GameObject maximum;

    /** Initialize the variables. **/ 
    void Start() {
        gameHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameHandler>();
        minimum = GameObject.Find("Minimum");
        maximum = GameObject.Find("Maximum");
    }

    /** Set up movement, fly status and music type once user clicks. **/ 
    void Update() {
        if (alive) {
            if (Input.GetMouseButtonDown(0)) {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, 1.0f);
                GetComponent<Animator>().SetBool("fly", true);
                gameHandler.playSFX(3);
            }
        }
    }

    /**
    * Unity function for physics processing
    * allowing to increase the speed in x.
    **/ 
    void FixedUpdate() {
        GetComponent<Rigidbody2D>().velocity = new Vector2(
            velocityX, GetComponent<Rigidbody2D>().velocity.y
        );
    }   

    /** Assign false to fly in case it stops. **/ 
    void restoreIdle() {
        GetComponent<Animator>().SetBool("fly", false);
    }

    /** Detect collision. **/ 
    void OnCollisionEnter2D(Collision2D collider) {
        if (alive) {
            gameHandler.playSFX(4);
            isDeath();
        }
    }

    /** Verify that it does not exceed the limits. **/ 
    void checkLimits() {
        if (alive) {
            if (transform.position.y > maximum.transform.position.y) {
                isDeath();
                gameHandler.playSFX(5);
            } 
            else if (transform.position.y < minimum.transform.position.y) {
                isDeath();
                gameHandler.playSFX(1);
            }
        }
    }

    /** When dead perform the following functions. **/ 
    void isDeath() {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        gameHandler.lost();
        velocityX = 0.0f;
        alive = false;
        gameHandler.lost();
        GetComponent<Rigidbody2D>().freezeRotation = false;
        gameHandler.replay.SetActive(true);
        gameHandler.backToMenu.SetActive(true);
    }

    /** Constantly check limits. **/ 
    void LateUpdate() {
        checkLimits();
    }
}
