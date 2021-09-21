using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSet: MonoBehaviour {
    public GameHandler gameHandler;

    // Start is called before the first frame update
    void Start() {
        gameHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameHandler>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            gameHandler.addPoints();
        }
    }
}
