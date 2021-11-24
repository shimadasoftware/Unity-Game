using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* SFX Class.
* In charge of managing the sounds of the game.
**/
public class SFX: MonoBehaviour {
    public List<AudioClip> audios;
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }

    /** Select the audio to play. **/ 
    public void play(int number) {
        GetComponent<AudioSource>().clip = audios[number];
        GetComponent<AudioSource>().Play();
    }
}
