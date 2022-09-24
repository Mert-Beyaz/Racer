using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float Speed, SpinSpeed;
    Rigidbody rb;
    public WheelCollider FL, FR, RL, RR;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        RL.motorTorque = Speed * Input.GetAxis("Vertical");
        RR.motorTorque = Speed * Input.GetAxis("Vertical");
        FL.steerAngle = SpinSpeed * Input.GetAxis("Horizontal");
        FR.steerAngle = SpinSpeed * Input.GetAxis("Horizontal");

    }
}

