using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
* Restart Class.
* In charge of managing the restart of the game.
**/
public class Restart: MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }

    /** Restart the game. **/ 
    public void restart() {
        SceneManager.LoadScene("Game");
    }
}
