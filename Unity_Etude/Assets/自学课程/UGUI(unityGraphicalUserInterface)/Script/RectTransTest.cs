using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectTransTest : MonoBehaviour
{
    public Vector2 si;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Overlay
        //获取imagetransform组件
        //this.transform.position只适用于覆盖模式，当画布为Overlay的时候-自身坐标系单位为像素和世界坐标单位为米系重合
        //transform.localPosition -> 当前的轴心点2d相对于父物体的UI的轴心点

        //FN+F12

        RectTransform trf = GetComponent<RectTransform>();
        //RectTransform rtf = this.transform as RectTransform;
        //获取锚点位置 自身轴心点相对于锚点的位置
        trf.anchoredPosition3D = new Vector3(1, 2,3);
        //trf.anchorMax
        //trf.anchorMin
        //获取 width height

        //只读
        //trf.rect.width;
        //trf.rect.height;
        //设置宽高
        trf.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 250);
        trf.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 250);
        //锚点的间距
        si = trf.sizeDelta;
    }
}
