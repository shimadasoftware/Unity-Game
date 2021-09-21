using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeHandler: MonoBehaviour {
    public float offsetX;
    public float maximum = 0.0f;
    public float minimum = -0.05f;
    public List<GameObject> pipes;

    // Start is called before the first frame update
    void Start() {
        if (GameObject.FindGameObjectWithTag("Pipe")) {
            pipes = new List<GameObject>(GameObject.FindGameObjectsWithTag("Pipe"));

            for (int i = 0; i < pipes.Count; i++) {
                pipes[i].transform.position = new Vector2(
                    pipes[i].transform.position.x, 
                    Random.Range(-0.3f, 0.0f)
                );
            }
        }
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void pushPipe() {
        pipes[0].transform.position = new Vector2(
            pipes[pipes.Count - 1].transform.position.x + offsetX, 
            Random.Range(-0.3f, 0.0f)
        );
        
        GameObject previous = pipes[0];
        pipes.RemoveAt(0);
        pipes.Insert(pipes.Count, previous);
    }
}
