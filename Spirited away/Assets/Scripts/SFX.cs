using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX: MonoBehaviour {
    public List<AudioClip> audios;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void play(int number) {
        GetComponent<AudioSource>().clip = audios[number];
        GetComponent<AudioSource>().Play();
    }
}
