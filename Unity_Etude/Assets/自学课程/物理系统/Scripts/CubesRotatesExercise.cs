using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesRotatesExercise : MonoBehaviour
{
    //射线信息
    RaycastHit hit;
    //存储临时游戏个体
    Transform tempsTrans;
    //存储开关
    bool iSwitch;
    //旋转速度
    public float iSpeed=10;


    // Update is called once per frame
    void Update()
    {
        //创建射线
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //发射射线
        if(Physics.Raycast(ray,out hit, 100)) {
            if(Input.GetMouseButtonDown(0)) {
                Transform trans = hit.transform;
                if(trans != tempsTrans) {
                    tempsTrans = trans;
                    iSwitch = true;
                } else {
                    iSwitch = !iSwitch;
                }
            }

        }
        if(iSwitch) {
            tempsTrans.Rotate(Vector3.forward * iSpeed);
        }
        
    }
}
