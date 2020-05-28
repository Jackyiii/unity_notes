using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex02 : MonoBehaviour
{
    public Vector3 axe;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(axe, Time.deltaTime * 100);
    }
}
