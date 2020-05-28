using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMe : MonoBehaviour{
    float speed;
    public Vector3 axe;
    private void Awake() {

    }
    void Start(){
        speed = 10.0f;
    }

    // Update is called once per frame
    void Update(){
        transform.Rotate(axe, Time.deltaTime * speed);

 
    }
}
