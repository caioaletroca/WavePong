using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    public float Velocity = 5;
    
    public float Randomness = 0;

    #region Private Variables
    
    private Rigidbody2D rb;
    private Vector2 velocity;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocity = new Vector2(Velocity, Velocity);
    }

    void FixedUpdate() {
        rb.velocity = velocity;
    }

    #region Collisions

    public void OnPlayerCollision(Collision2D col)
    {
        velocity = Vector2.Reflect(velocity, col.GetContact(0).normal).Rotate(0);
    }

    public void OnWallCollision(Collision2D col) {
        velocity = Vector2.Reflect(velocity, col.GetContact(0).normal);
    }

    #endregion
}
