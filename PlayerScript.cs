using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    private float xAxis;
    private float zAxis;

    void Update()
    {
        xAxis = Input.GetAxisRaw("Horizontal");
        zAxis = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3( xAxis*speed*Time.deltaTime, rb.velocity.y, zAxis*speed*Time.deltaTime);
    }
}
