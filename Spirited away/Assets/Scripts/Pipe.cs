using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* Pipe Class.
* In charge of managing the functionalities of the pipes.
**/
public class Pipe: MonoBehaviour {    
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }

    /** Make the pipes invisible. **/
    private void OnBecameInvisible() {
        transform.parent.transform.parent.GetComponent<PipeHandler>().pushPipe();
    }
}
