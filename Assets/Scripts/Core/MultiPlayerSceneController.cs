using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MultiPlayerSceneController : BaseSceneController
{
    #region Public Properties

    #endregion

    #region Unity Methods

    public void Start()
    {
        Debug.Log("Firing Game Start Event");
        OnGameEvent.Invoke(new GameEvent.Parameter()
        {
            Type = (int)GameEvent.Types.Start
        });
    }
        
    #endregion

    #region Public Methods

    public void OnPlayerDeath()
    {
        Debug.Log("Firing Game Restart Event");
        OnGameEvent.Invoke(new GameEvent.Parameter()
        {
            Type = (int)GameEvent.Types.Restart
        });
        // Add score
    }
        
    #endregion
}