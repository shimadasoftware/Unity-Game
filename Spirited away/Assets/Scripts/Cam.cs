using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* Cam Class.
* In charge of managing the functionalities of the camera.
**/
public class Cam : MonoBehaviour {
    public float initialPositionY;
    
    /** Initialize the variables. **/ 
    void Start() {
        initialPositionY = transform.position.y;
    }

    // Update is called once per frame
    void Update() {
        
    }

    /**
    * Once the movement is detected,
    * the camera is set in the same position in x and y
    * corresponds to the one it had at the beginning.
    **/ 
    void LateUpdate() {
        transform.position = new Vector3(transform.position.x, initialPositionY, transform.position.z);
    }
}