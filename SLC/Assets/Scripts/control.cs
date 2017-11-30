using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
    public int turn ;
    public int speed;
    public float drift ;
    private Rigidbody2D rb;

    void Start () {
		rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        
    }

    void FixedUpdate () {
        if (Input.GetButton("Accelerate"))
        {
            rb.AddForce(this.transform.up * speed);
        }
        //rb.AddTorque(-Input.GetAxis("Horizontal") * turn);
        rb.angularVelocity = -Input.GetAxis("Horizontal")*turn;
        Vector2 forwardVel = transform.up * Vector2.Dot(rb.velocity,transform.up);
        Vector2 rightVel = transform.right * Vector2.Dot(rb.velocity, transform.right);
        rb.velocity = forwardVel + rightVel * drift;

    }
}
