using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 850f;

    private Rigidbody2D myBody;
    
    void Awake()
    {
        myBody = gameObject.GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = myBody.velocity;
        vel.x = Input.GetAxis("Horizontal") * speed;
        myBody.velocity = vel;
    }
}
