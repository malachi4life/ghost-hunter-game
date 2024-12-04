using System.Security.Cryptography;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 0.5f;
    private Vector2 direction;
    private float changeDirectionTime = 1f;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timer = changeDirectionTime;
        }

        transform.Translate(direction * speed * Time.deltaTime);
    }
}
