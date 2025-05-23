using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    [Header("Control the speed of the Asteroid")]
    public float maxSpeed;
    public float minSpeed;


    [Header("Control the rotational speed")]
    public float rotationalSpeedMin;
    public float rotationalSpeedMax;

    private float rotationalSpeed;
    private float xAngle;
    private float yAngle;
    private float zAngle;

    public Vector3 movementDirecation;
    private float asteroidSpeed;

    void Start()
    {
        //get a random speed
        asteroidSpeed = Random.Range(minSpeed, maxSpeed);
        //get a random rotation
        xAngle = Random.Range(0,360);
        yAngle = Random.Range(0,360);
        zAngle = Random.Range(0,360);
        
        transform.Rotate(xAngle,yAngle,zAngle);

        rotationalSpeed = Random.Range(rotationalSpeedMin, rotationalSpeedMax);
    }

    void Update() 
    {
        transform.Translate(movementDirecation * Time.deltaTime *asteroidSpeed, Space.World);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationalSpeed);
    }
}
