using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {
    public float initialPositionY;
    
    // Start is called before the first frame update
    void Start() {
        initialPositionY = transform.position.y;
    }

    // Update is called once per frame
    void Update() {
        
    }

    void LateUpdate() {
        transform.position = new Vector3(transform.position.x, initialPositionY, transform.position.z);
    }
}