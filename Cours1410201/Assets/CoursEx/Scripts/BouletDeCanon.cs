using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouletDeCanon : MonoBehaviour{
    public GameObject ballPrefab;

    // Update is called once per frame
    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            // Create a bullet if hit
            GameObject ball = Instantiate(ballPrefab, transform.position, transform.rotation);
        }
    }
}
