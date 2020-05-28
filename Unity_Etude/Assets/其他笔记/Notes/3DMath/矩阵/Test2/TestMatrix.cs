using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMatrix : MonoBehaviour
{
    Mesh mesh;
    public Vector3[] vertices;
    public int[] triangles;

    // Start is called before the first frame update
    void Start()
    {
        //实例化网格
        mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        transform.GetComponent<MeshFilter>().mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
