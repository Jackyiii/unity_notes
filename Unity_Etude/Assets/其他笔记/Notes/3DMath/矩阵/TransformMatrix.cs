using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMatrix : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.transform.localToWorldMatrix);
        Debug.Log(this.transform.localToWorldMatrix.transpose);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
