using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUnityVector : MonoBehaviour
{
    
    public bool isEqual(Vector3DTest ov,Vector3 uv)
	{
        if(ov.x == uv.x && ov.y == uv.y && ov.z == uv.z) {
            return true;
        }
        return false;
	}
    // Start is called before the first frame update
    void Start()
    {
        Vector3DTest ov1 = new Vector3DTest(1.1f, 1.2f, 1.3f) + new Vector3DTest(1, 2, 3);
        Vector3 uv1 = new Vector3(1.1f, 1.2f, 1.3f) + new Vector3(1, 2, 3);
        if(isEqual(ov1,uv1)) {
            Debug.Log("add equal...");
        }
        Vector3DTest ov2 = new Vector3DTest(1.1f, 1.2f, 1.3f) - new Vector3DTest(1, 2, 3);
        Vector3 uv2 = new Vector3(1.1f, 1.2f, 1.3f) - new Vector3(1, 2, 3);
        if(isEqual(ov2, uv2)) {
            Debug.Log("sub equal...");
        }
        ov2.normalize();
        uv2.Normalize();
        if(isEqual(ov2, uv2)) {
            Debug.Log("normolize equal...");
        }
        Debug.Log("======================");
        Vector3DTest ov3 = new Vector3DTest(1, 2, 3).corss(new Vector3DTest(-5, 7, 10));
        Vector3 uv3 = Vector3.Cross(new Vector3(1, 2, 3),new Vector3(-5,7,10));
        if(isEqual(ov3, uv3)) {
            Debug.Log("cross equal.....");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
