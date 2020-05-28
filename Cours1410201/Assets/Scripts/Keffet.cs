using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keffet : MonoBehaviour
{
    public float speed;
	public bool change;
    // Update is called once per frame
    void Update()
    {
        transform.position=new Vector3(Mathf.PingPong(Time.time, 1f), 0, 0);
    }
}
