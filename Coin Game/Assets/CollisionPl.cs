using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPl : MonoBehaviour
{
    public Rigidbody rb;
    public Transform t;
    //float vl = rb.velocity.y;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Coin")
        {
            
            Destroy(collision.gameObject);
            FindObjectOfType<collectables>().Spawner();
            FindObjectOfType<Score>().counter();
           
            
        }
        if (collision.collider.name == "Ground")
        {
            Debug.Log(rb.velocity);
            rb.velocity = new Vector3(0, 9.2f, 0);
            
        }
        



    }
   
}
