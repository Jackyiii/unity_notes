using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gogo : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) {
            animator.SetBool("walk", true);
        } else if(Input.GetKeyUp(KeyCode.W))
            {
            animator.SetBool("walk", false);
        }
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
        //animator?.SetBool("walk", Mathf.Abs(h) > 0f || Mathf.Abs(v) > 0);
    }
}
