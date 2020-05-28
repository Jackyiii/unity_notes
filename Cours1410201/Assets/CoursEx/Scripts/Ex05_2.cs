using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex05_2 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time, 1), 0.0f, 0.0f);
    }
}
