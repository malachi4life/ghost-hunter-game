using System.Diagnostics;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the enemy
        if (collision.gameObject.tag == "Enemy")
        {
            UnityEngine.Debug.Log("Collided with Enemy!");

            // Example action: Reduce player health or capture the enemy
        }
    }
}
