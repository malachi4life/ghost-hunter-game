using System.Diagnostics;
using System.Globalization;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public PlayerHealth playerHealth;
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with an object tagged "Enemy"
        if (collision.gameObject.tag == "Enemy")
        {
            UnityEngine.Debug.Log("Collided with Enemy!");

            // Example: Reduce player health on collision with an enemy
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(10f);  // Deal 10 damage (adjust based on your game design)
            }

            float playerHealthCurrent = playerHealth.GetCurrentHealth();

            UnityEngine.Debug.Log("Player health: " + playerHealthCurrent);

            // Optional: Trigger enemy capture or defeat
            //CaptureEnemy();
        }
    }
}
