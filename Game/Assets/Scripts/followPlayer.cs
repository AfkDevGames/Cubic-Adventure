
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    //Vector3 daje sve 3 ose kao opcije u Unity-u
    public Transform Player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position + offset;
    }
}
