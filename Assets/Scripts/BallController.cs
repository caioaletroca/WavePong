using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallController : MonoBehaviour
{
    #region Public Properties

    [Tooltip("Maximum randomness in degrees")]
    public float MaxRandomness = 90;

    [Tooltip("Ball Model Data")]
    public BallModelScriptableObject model;

    #endregion

    #region Private Variables
    
    private Rigidbody2D rb;

    #endregion

    #region Unity Methods

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        rb.velocity = model.Velocity;
    }
        
    #endregion

    #region Collisions

    public void OnPlayerCollision(Collision2D col)
    {
        // TODO: Fix this
        model.Velocity = Vector2.Reflect(model.Velocity, col.GetContact(0).normal).Rotate(model.Randomness * MaxRandomness);
    }

    public void OnWallCollision(Collision2D col) {
        model.Velocity = Vector2.Reflect(model.Velocity, col.GetContact(0).normal);
    }

    #endregion
}
