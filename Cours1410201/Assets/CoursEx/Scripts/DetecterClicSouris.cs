using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetecterClicSouris : MonoBehaviour
{
    public GameObject ballPrefab;
    public float pussince = 1000.0f;
    private float timer;
    private bool start=false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            start = true;
            while(start) {
                timer++;
            }
        }
        if(Input.GetMouseButtonUp(0)) {
            // Construct a ray from the current mouse coordinates
            start = false;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Create a bullet if hit
            GameObject ball = Instantiate(ballPrefab, transform.position, transform.rotation);
            // launch the ball
            ball.GetComponent<Rigidbody>().AddForce(ray.direction * 100.0f*timer);
            
            Debug.Log(timer);
            timer = 0.0f;
        }
    }
}
