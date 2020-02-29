using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
public  KeyCode upButton = KeyCode.W; 
public  KeyCode downButton = KeyCode.S;
public float speed = 10.0f;
public float yBoundary = 2.25f;
private Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       var vel = rigidbody2D.velocity;
       if (Input.GetKey(upButton))
       {
           vel.y = speed;
       }
       else if (Input.GetKey(downButton))
       {
           vel.y = -speed;
       }
       else
       {
           vel.y = 0;
       }
    rigidbody2D.velocity = vel;

        var pos = transform.position;
        if (pos.y > yBoundary)
        {
            pos.y = yBoundary;
        }
        else if (pos.y < -yBoundary)
        {
            pos.y = -yBoundary;
        }
    transform.position = pos;
    }

}
