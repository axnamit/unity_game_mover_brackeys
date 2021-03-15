
using UnityEngine;

public class PlayerColliasion : MonoBehaviour
{

    public PlayerMovement playerMovement;

     void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag);
        if (collision.collider.tag == "colliader")
        {
            Debug.Log("hit hit hit ");
            playerMovement.enabled = false;
        }
    }
}
