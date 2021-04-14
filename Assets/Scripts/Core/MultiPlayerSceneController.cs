using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiPlayerSceneController : BaseSceneController {

    #region Public Properties

    [Tooltip("Time to delay in seconds for start the match")]
    public float StartDelay = 1f;

    [Tooltip("Ball velocity in the start of the match")]
    public float InitialVelocity = 1f;

    [Tooltip("Ball Model data")]
    public BallModelScriptableObject BallModel;

    #endregion

    #region Unity Methods

    public void Start()
    {
        StartCoroutine(StartDelayed());
    }
        
    #endregion

    #region Public Methods

    public void OnPlayerDeath(Collision2D collision)
    {
        // Add score

        // Reset scene
    }
        
    #endregion

    #region Coroutines

    IEnumerator StartDelayed()
    {
        yield return new WaitForSeconds(StartDelay);

        Debug.Log("Starting ball movement");
        // Sets ball velocity
        BallModel.Velocity = Random.insideUnitCircle.normalized * InitialVelocity;
    }
        
    #endregion
}