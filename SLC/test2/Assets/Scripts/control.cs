using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
    public int speed;
    public int turn2,turn;
    public float drift ;
    private int torque;
    private Rigidbody2D rb;

    void Start () {
		rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        
    }

    void FixedUpdate () {

        
        if (Input.GetAxis("Vertical") >= 0)
        {
            torque = turn;
        }
        else torque = turn2;
        rb.AddForce(Input.GetAxis("Vertical") * speed * transform.up);
        rb.angularVelocity = -Input.GetAxis("Horizontal")*torque;
        Vector2 forwardVel = transform.up * Vector2.Dot(rb.velocity,transform.up);
        Vector2 rightVel = transform.right * Vector2.Dot(rb.velocity, transform.right);
        rb.velocity = forwardVel + rightVel * drift;

    }
}
