using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTrans: MonoBehaviour
{
    public Matrix4x4 matrix;

    public Matrix4x4 v1;
    // Start is called before the first frame update
    void Start()
    {
        matrix.SetTRS(
            transform.position,
            transform.rotation,
            transform.localScale
            );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
