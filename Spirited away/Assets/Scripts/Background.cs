using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background: MonoBehaviour {
    public float speedMovement;
    Renderer renderer;

    // Start is called before the first frame update
    void Start() {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update() {
        Vector2 movement = new Vector2(Mathf.Repeat(Time.time * speedMovement, 1), 0.0f);
        renderer.sharedMaterial.SetTextureOffset("_MainTex", movement);
    }
}
