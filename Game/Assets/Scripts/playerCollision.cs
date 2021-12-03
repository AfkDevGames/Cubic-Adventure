using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;

       //Obrisi sve i pisi " void OnCollisionEnter" za sudar sa drugim objektima

    void OnCollisionEnter(Collision collisionInfo )
    {
        if(collisionInfo.collider.tag == "Obstacle" || collisionInfo.collider.tag == "Cylinder")
        {
            movement.enabled = false;
            //
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
