using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVector3 : MonoBehaviour
{
    public float speed =0.0f;
    public Vector3 dir = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pre = this.gameObject.transform.position;
        Vector3 now = dir * speed+pre;
        this.gameObject.transform.position = now;

    }
}
