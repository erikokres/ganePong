using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    void GoBall(){
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rigidbody2D.AddForce(new Vector2(20, -15));
        }
        else 
        {
            rigidbody2D.AddForce(new Vector2(-20, -15));
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }

    // Update is called once per frame
   // void Update()
    //{
        void ResetBall(){
            rigidbody2D.velocity = Vector2.zero;
            transform.position = Vector2.zero;
        }
        void RestartGame(){
            ResetBall();
            Invoke("GoBall", 1);
        }
        void OnCollisionEnter2D(Collision2D coll) {
            if (coll.collider.CompareTag("Plaayer")){
                Vector2 vel;
                vel.x = rigidbody2D.velocity.x;
                vel.y = (rigidbody2D.velocity.y/2) + (coll.collider.attachedRigidbody.velocity.y / 3);
                rigidbody2D.velocity = vel;
            }
        }
   //    }
}
