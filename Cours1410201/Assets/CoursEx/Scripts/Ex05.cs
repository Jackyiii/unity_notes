using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex05 : MonoBehaviour
{
    float sens = 10.0f;


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(sens * Time.deltaTime,0.0f,0.0f);
        if (transform.position.x > 10.0f) {
            sens = -10.0f;
        }
        else if (transform.position.x < 0.0f) {
            sens = 10.0f;
        }
        Debug.Log("sens+"+sens+"Time.deltaTime:"+Time.deltaTime+"sens*Time.deltaTime:"+sens*Time.deltaTime);
    }
}
