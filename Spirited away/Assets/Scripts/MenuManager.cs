using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
* Menu Manager Class.
* In charge of managing the functionalities of the interfaces.
**/
public class MenuManager: MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }

    /** Load the game scene once the start button is pressed. **/ 
    public void StartButton() {
        SceneManager.LoadScene("Game");
    }

    /** Back to main menu. **/ 
    public void GoBack() {
        SceneManager.LoadScene("MainMenu");
    }

    /** End the application. **/ 
    public void QuitButton() {
        Debug.Log("Quit");
        Application.Quit();
    }
}
