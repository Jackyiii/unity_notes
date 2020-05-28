using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomScript : MonoBehaviour
{
	 
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		float val = Mathf.Sin(Time.time);
		transform.localScale = new Vector3(val, val, val);
        
	}
}
