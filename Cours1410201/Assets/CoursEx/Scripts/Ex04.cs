using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex04 : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime);
        if (transform.position.x > 1.0f) {
            transform.position = Vector3.zero;
        }        
    }
}
