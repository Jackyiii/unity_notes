using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesRotates : MonoBehaviour
{
    ///<summary>
    ///处理小方块射线的旋转问题
    ///1创建射线
    ///2发射射线
    ///3按鼠标左键
    ///鼠标左键点击到的对象，让其旋转
    ///4设置临时变量开关，存储状态，true-旋转状态，false-停止旋转
    ///5transform的变量，存储转的个体，当下一个的时候前面的设置成false
    /// </summary>
    // Start is called before the first frame update

    //记录信息
    RaycastHit hit;
    //旋转速度
    public float speed=10;
    //全局变量Trans记录旋转对象
    Transform tempsTrans;
    //开关
    bool isRotate = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //创建射线
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //发射射线
        if(Physics.Raycast(ray, out hit, 100)) {
            //按下鼠标左键
            if(Input.GetMouseButtonDown(0)) {
                //存储射到的游戏个体
                Transform trans = hit.transform;
                if(trans != tempsTrans) {
                    //临时的变量进行赋值
                    tempsTrans = trans;
                    //状态设置为true
                    isRotate = true;
                } else {
                    //取相反的值，因为第三次点击应该是true
                    isRotate =!isRotate;
                }
                
            }
        }
        //旋转。如果开关是true，那么就旋转
        if(isRotate) {
            tempsTrans.Rotate(Vector3.up * speed);
        }
        
    }
}
