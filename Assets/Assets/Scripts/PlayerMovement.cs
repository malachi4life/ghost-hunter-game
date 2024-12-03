using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            // Temporarily increase the speed
            speed = 10f; // Adjust the boosted speed value as needed
        }
        else
        {
            // Reset to the default speed
            speed = 5f; // Default speed value
        }
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
