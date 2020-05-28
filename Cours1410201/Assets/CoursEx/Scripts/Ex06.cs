using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex06 : MonoBehaviour
{
    float timer = 0.0f;
    int cote = 0;
    Vector3 source;
    Vector3 dest;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1.0f) {
            timer = 0.0f;
            cote++;
            if (cote > 3) {
                cote=0;
                
            }
            source = dest;
            switch (cote) {
                case 0:     dest = new Vector3(5.0f, -5.0f);break;
                case 1:     dest = new Vector3(5.0f, 5.0f);break;
                case 2:     dest = new Vector3(-5.0f, 5.0f); break;
                default:    dest = new Vector3(-5.0f, -5.0f);break;
            }
        }
        transform.position = Vector3.Lerp(source, dest, timer);
    }
}
