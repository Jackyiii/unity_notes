using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex03 : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        float val= Mathf.Sin(Time.time);
        transform.localScale = new Vector3(val, val, val);
        Debug.Log("time"+Time.time);
        Debug.Log("DeltaTime:" + Time.deltaTime);
    }
}
