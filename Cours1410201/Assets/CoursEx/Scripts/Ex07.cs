using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex07 : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.position = 5.0f * new Vector3(Mathf.Cos(Time.time), Mathf.Sin(Time.time), 0.0f);
    }
}
