using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothSuivi_testLerp : MonoBehaviour
{
	public GameObject ob;
    private Transform targetPostion;
    public float smoth=5.0f;
    private Material m1;
    private void Awake() {
        targetPostion =ob.GetComponent<Transform>();
        m1 = ob.GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPostion.position, smoth*Time.deltaTime);
        m1.SetColor("_Color",Color.red);
        m1.color = Color.red;
        
    }
}
