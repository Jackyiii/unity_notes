using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex08 : MonoBehaviour
{
    Material m;
    // Start is called before the first frame update
    void Start()
    {
        m = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = 5.0f * new Vector3(Mathf.Cos(Time.time), 0.0f, 0.0f);
        if(transform.position.x > 0.0f) {
            m.color = Color.red;
        } else {
            m.color = Color.gray;
        }
        Debug.Log(Mathf.Cos(Time.time));
    }
}
