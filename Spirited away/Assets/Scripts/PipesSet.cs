using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* Pipe Set Class.
* In charge of managing of the pipe set functionalities.
**/
public class PipesSet: MonoBehaviour {
    public GameHandler gameHandler;

    /** Initialize the variables. **/ 
    void Start() {
        gameHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameHandler>();
    }

    // Update is called once per frame
    void Update() {
    }

    /** To verify the element that entered the middle of the pipes. **/ 
    public void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            gameHandler.addPoints();
        }
    }
}
