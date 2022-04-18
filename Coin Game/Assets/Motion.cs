using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    public Rigidbody rb;
    public int sideforce = 50;


    // Update is called once per frame
    void FixedUpdate()
    {

      
        if (Input.GetKey("left"))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.Force);
            
        }
        else if (Input.GetKey("right"))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.Force);
        }
        else if (Input.GetKey("up"))
        {
            rb.AddForce(0,0, sideforce * Time.deltaTime, ForceMode.Force);
        }
        else if (Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -sideforce * Time.deltaTime, ForceMode.Force);
        }
        if (rb.position.y < -2 || Input.GetKey("escape"))
        {
            Application.Quit();
        }
     
    }
}
