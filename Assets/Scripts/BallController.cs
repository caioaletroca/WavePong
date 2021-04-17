using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallController : MonoBehaviour
{
    #region Public Properties

    [Tooltip("Time to delay in seconds for start the match")]
    public float StartDelay = 1f;

    [Tooltip("Ball velocity in the start of the match")]
    public float InitialVelocity = 1f;

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

    #region Public Methods

    public void OnGameStart()
    {
        StartCoroutine(StartDelayed());
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

    #region Coroutines

    IEnumerator StartDelayed()
    {
        // Stop ball
        model.Velocity = Vector2.zero;
        transform.position = Vector2.zero;

        yield return new WaitForSeconds(StartDelay);

        // Start ball
        model.Velocity = UnityEngine.Random.insideUnitCircle.normalized * InitialVelocity;
    }
        
    #endregion
}
