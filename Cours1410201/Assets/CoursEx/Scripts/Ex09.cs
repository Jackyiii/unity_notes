using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex09 : MonoBehaviour
{
    public Material m;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(5.0f * Mathf.Cos(Time.time), 0.0f,0.0f);
        if(transform.position.x > 0.0f) {
            m.color = Color.red;
        } else {
            m.color = Color.black;
        }
    }
}
