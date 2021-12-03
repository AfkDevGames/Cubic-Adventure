using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDCode : MonoBehaviour
{
    public Rigidbody2D DKey;
    public float moveforce = 0.1f;
    private float moveHorizontal;
    private float moveVertical;


    void Start()
    {
        //RightArrow2.SetActive(false);

    }

    void Update()
    {

        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
    }



    void FixedUpdate()
    {


        if (moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {
            DKey.AddForce(new Vector2(moveHorizontal * moveforce, 0f));
        }
        if (moveVertical > 0.1f || moveVertical < -0.1f)
        {
            DKey.AddForce(new Vector2(0f, moveVertical * moveforce));
        }


    }
}
