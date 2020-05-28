using System;
using System.Collections;
using System.Collections.Generic;


public class Vector3DTest
{
    public float x;
    public float y;
    public float z;
    public Vector3DTest(float x=0.0f,float y=0.0f,float z=0.0f)
	{
		this.x = x;
		this.y = y;
		this.z = z;
	}
    public Vector3DTest(Vector3DTest vec)
	{
		this.x = vec.x;
		this.y = vec.y;
		this.z = vec.z;
	}
    public Vector3DTest add(Vector3DTest vec)
	{
		Vector3DTest ret = new Vector3DTest(x, y, z);
		ret.x += vec.x;
		ret.y += vec.y;
		ret.z += vec.z;
		return ret;

	}
    public Vector3DTest sub(Vector3DTest vec)
	{
		Vector3DTest ret = new Vector3DTest(x, y, z);
		ret.x -= vec.x;
		ret.y -= vec.y;
		ret.z -= vec.z;
		return ret;
	}

    public static Vector3DTest operator + (Vector3DTest lv, Vector3DTest rv)
	{
		return lv.add(rv);
	}
    public static Vector3DTest operator - (Vector3DTest lv,Vector3DTest rv)
	{
		return lv.sub(rv);
	}

    public Vector3DTest corss (Vector3DTest vec) {
        Vector3DTest ret = new Vector3DTest();
        ret.x = y * vec.z - z*vec.y;
        ret.y = z * vec.x - x * vec.z;
        ret.z = x * vec.y - y * vec.x;
        return ret;
    }
    public void normalize()
	{
		float length = (float)Math.Sqrt(x * x+ y * y+ z * z);
		x /= length;
		y /= length;
		z /= length;
	}
	public override string ToString()
	{
		return string.Format("(" + x + "," + y + "," + z + ")");
	}
}
