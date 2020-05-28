using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pyramide : MonoBehaviour
{
    public int nb_etages = 5;
    public Object cube1;
    public Object cube2;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int j = 0; j < nb_etages; j++) {
            for(int i = 0; i < nb_etages - j; i++) {
                Object cube;
                if(i % 2 == 0) {
                    cube = cube1;
                } else {
                    cube = cube2;
                }
                
                Vector3 position = new Vector3(i * 1.5f + j * 0.75f, 0.5f + j, 0.0f);
                //position += plan.transform.position;
                GameObject.Instantiate(cube, position, Quaternion.identity);
                
            }
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
        //Object.Destroy(cube1);
    }
}
