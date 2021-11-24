/**
* Version: 1.0
* Universidad Santo Tomás Tunja
* Simulation
* @author: Juana Valentina Mendoza Santamaría
* @author: Alix Ivonne Chaparro Vasquez
* Presented to: Martha Susana Contreras Ortiz
* Code based on: https://www.udemy.com/course/como-crear-flappy-bird-en-unity/ 
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* Background Class.
* In charge of managing the functionalities of the background.
**/
public class Background: MonoBehaviour {
    public float speedMovement;
    Renderer renderer;

    /** Initialize the variables. **/ 
    void Start() {
        renderer = GetComponent<Renderer>();
    }

    /**
    * Calculate the displacement by the duration of the game
    * and generate a movement effect by means of a rendering.
    **/ 
    void Update() {
        Vector2 movement = new Vector2(Mathf.Repeat(Time.time * speedMovement, 1), 0.0f);
        renderer.sharedMaterial.SetTextureOffset("_MainTex", movement);
    }
}
