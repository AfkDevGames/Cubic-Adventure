using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    
    // Start is called before the first frame update

    // Update is called once per frame

    //Fixed update for physics
    void FixedUpdate()
    {
        //try
        // RigidbodyConstraints.FreezeRotationX |
        //GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX; //| RigidbodyConstraints.FreezeRotationZ;

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {                              // ForceMode.VelocityChange za bolje pomeranje
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
