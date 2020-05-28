using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBullet : MonoBehaviour
{
    public float speedBullet=30;
    Rigidbody rig;
    public float power=1000;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        //子弹自身的移动
        //transform.Translate(transform.forward * speedBullet);
        rig.AddForce(transform.forward * power, ForceMode.Force);
     
    }
    //消灭敌人
    private void OnCollisionEnter(Collision col) {
        //检测敌人
        if(col.transform.tag == "Enemys") {
            Destroy(col.gameObject, 1);
        }
    }
}
