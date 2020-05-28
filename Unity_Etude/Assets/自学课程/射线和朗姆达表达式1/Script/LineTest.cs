using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTest : MonoBehaviour {
    public Transform ob1;
    public Transform ob2;
    //射线的反馈信息
    RaycastHit hit;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if(Physics.Linecast(ob1.position, ob2.position, out hit)) {
            //获取到检测的物体以后我们需要修改和改变
            hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        Debug.DrawLine(ob1.position, ob2.position,Color.grey);
    }
}