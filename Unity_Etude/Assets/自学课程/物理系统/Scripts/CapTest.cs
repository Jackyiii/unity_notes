using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

public class CapTest : MonoBehaviour
{
    float fh;
    float fv;
    public float speedRotate=10;
    public float speedMove=10;
    //子弹原型
    public GameObject bullet;
    //子弹的生成位置
    public Transform mtrans;
    //检测信息
    RaycastHit hit;
    //定义标签层级
    int layerMask;
    public RectTransform pointUI;
    // Start is called before the first frame update
    void Start()
    {
        layerMask = (1<<9);
    }

    // Update is called once per frame
    void Update()
    {
        //获取轴值
        //处理移动
        fh=Input.GetAxis("Horizontal");
        fv=Input.GetAxis("Vertical");
        //移动旋转
        if(fh != 0 || fv != 0) {
            //旋转
            transform.Rotate(Vector3.up,fh*speedRotate*Time.deltaTime);
            //移动
            //默认的是自身空间，需要加spaceworld
            transform.Translate(transform.forward * fv * speedMove * Time.deltaTime,Space.World);
        }
        //发射射线
        if(Physics.Raycast(mtrans.position, mtrans.forward,out hit,100,layerMask)) {
            //显示准星
            pointUI.gameObject.SetActive(true);
            //准星位置
            pointUI.position = hit.point;
            //准星的旋转-枪口保持一致
            pointUI.rotation = mtrans.rotation;
            //绘制射线
            Debug.DrawLine(mtrans.position, hit.point, Color.blue);

        } //没射到
        else {
            pointUI.gameObject.SetActive(false);
        }
        //发射子弹
        if(Input.GetKeyDown(KeyCode.Space)) {
            //生成子弹
            GameObject obj = Instantiate(bullet, mtrans.position,mtrans.rotation);

        }
    }
}
