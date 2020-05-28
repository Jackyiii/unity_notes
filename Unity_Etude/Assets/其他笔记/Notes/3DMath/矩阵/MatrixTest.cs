using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Matrix4x4 a = new Matrix4x4();
        for(int i = 0; i < 16; i++) {
            a[i] = Random.Range(1, 50);
        }
        Matrix4x4 b = new Matrix4x4();
        for(int i = 0; i < 16; i++) {
            b[i] = Random.Range(1, 50);
        }
        Debug.Log(a * b);
        Matrix4x4 c = a.transpose;
        Matrix4x4 d = b.transpose;
        Debug.Log((d * c).transpose);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
