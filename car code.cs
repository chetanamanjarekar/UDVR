using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyaerCarController : MonoBehaviour
{

    [Header("Wheels collider")]
    public WheelCollider frontLeftWheelCollider;
    public WheelCollider frontRightWheelCollider;
    public WheelCollider backLeftWheelCollider;
    public WheelCollider backRightWheelCollider;

    [Header("Wheels Transform")]

    public Transform frontLeftWheelTransform;
    public Transform frontRightwheelTransform;
    public Transform backLeftWheelTransform;
    public Transform backRightWheelTransform;

    [Header("Car Engine")]
    public float accelerationForce = 300f;
    public float breakingForce = 3000f;
    public float presentBreakForce = 0f;
    public float presentAcceleration = 0f;
    private void Update()

    {
        MoveCar();
    }

    private void MoveCar()

    {


        frontLeftWheelCollider.motorTorque = presentAcceleration;
        frontRightWheelCollider.motorTorque = presentAcceleration;
        presentAcceleration = accelerationForce + Input.GetAxis("Vertical");

    }
}















using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyaerCarController : MonoBehaviour
{

    [Header("Wheels collider")]
    public WheelCollider frontLeftWheelCollider;
    public WheelCollider frontRightWheelCollider;
    public WheelCollider backLeftWheelCollider;
    public WheelCollider backRightWheelCollider;

    [Header("Wheels Transform")]

    public Transform frontLeftWheelTransform;
    public Transform frontRightwheelTransform;
    public Transform backLeftWheelTransform;
    public Transform backRightWheelTransform;

    [Header("Car Engine")]
    public float accelerationForce = 300f;
    public float breakingForce = 3000f;
    public float presentBreakForce = 0f;
    public float presentAcceleration = 0f;


    [Header("Car Steering")]
    public float wheelsTorque = 35f;
    private float presentTurnAngle = 0f;
    
    private void Update()

    {
        MoveCar();
        CarSteering();
    }

    private void MoveCar()

    {


        frontLeftWheelCollider.motorTorque = presentAcceleration;
        frontRightWheelCollider.motorTorque = presentAcceleration;
        backLeftWheelCollider.motorTorque = presentAcceleration;
        backRightWheelCollider.motorTorque = presentAcceleration;

        presentAcceleration = accelerationForce + Input.GetAxis("Vertical");

    }
    private void CarSteering()
    { 
        presentTurnAngle = wheelsTorque + Input.GetAxis("Horizontal");
        frontLeftWheelCollider.steerAngle = presentTurnAngle;
        frontRightWheelCollider.steerAngle =  presentTurnAngle;

    }
}

