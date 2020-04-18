using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

[RequireComponent(typeof(RigidBody2D))]
public class PlayerMovement : MonoBehaviour
{
    //Player rotates up ward and downward
    public float tapForce = 10;
    public float tiltSmooth = 5;
    public Vector3 startPos;

    Rigidbody2D rigidbody;
    //form of rotation
    Quaternion downRotation;
    Quaternion forwardRotation; 

    void Start()
    {
        rigidbody = GetComponent<Ridigbody2D>();
        downrotation = Quaternion.Euler(0, 0, -90);
        forwardRotation = Quaternion.Euler(0, 0, 35);
        
    }

    void Update() 
    {
        //indicated player movement when space button is pressed
        if (Input.GetSpaceButtonDown(0))
        {
            transform.rotation = forwardRotation;
            rigidbody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltSmooth * Timeout.deltaTime);    
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "") ;
    }
}