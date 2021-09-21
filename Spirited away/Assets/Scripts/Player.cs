using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour {
    public float velocityX;
    public float increasedSpeed;
    public bool alive = true;
    public GameHandler gameHandler;
    public GameObject minimum;
    public GameObject maximum;

    // Start is called before the first frame update
    void Start() {
        gameHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameHandler>();
        minimum = GameObject.Find("Minimum");
        maximum = GameObject.Find("Maximum");
    }

    // Update is called once per frame
    void Update() {
        if (alive) {
            if (Input.GetMouseButtonDown(0)) {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, 1.0f);
                GetComponent<Animator>().SetBool("fly", true);
                gameHandler.playSFX(3);
            }
        }
    }

    void FixedUpdate() {
        GetComponent<Rigidbody2D>().velocity = new Vector2(
            velocityX, GetComponent<Rigidbody2D>().velocity.y
        );
    }

    void restoreIdle() {
        GetComponent<Animator>().SetBool("fly", false);
    }

    void OnCollisionEnter2D(Collision2D collider) {
        if (alive) {
            gameHandler.playSFX(4);
            isDeath();
        }
    }

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

    void isDeath() {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        gameHandler.lost();
        velocityX = 0.0f;
        alive = false;
        gameHandler.lost();
        GetComponent<Rigidbody2D>().freezeRotation = false;
    }

    void LateUpdate() {
        checkLimits();
    }
}
