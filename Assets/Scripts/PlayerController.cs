using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
    }

    // performed before physics calculation
    void FixedUpdate() {
        float steering = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(0, 0, steering);
        rb.AddForce(movement * 50);
    }
}
