using System;
using UnityEngine;
using UnityEngine.Events;

public class GameEventHandler : MonoBehaviour
{
    #region Types

    /// <summary>
    /// Defines a internal event handler
    /// </summary>
    [Serializable]
    public class HandlerEvent : UnityEvent { }
        
    #endregion
    
    #region Public Properties

    [Tooltip("The type of event to listen to")]
    public GameEvent.Types Type;

    [Tooltip("Event fired for the specified type")]
    public HandlerEvent OnEvent;

    #endregion

    #region Unity Methods

    private void Start()
    {
        // Registers into game events
        FindObjectOfType<BaseSceneController>()?.OnGameEvent?.AddListener(OnGameEvent);
    }
        
    #endregion

    #region Unity Events

    private void OnGameEvent(GameEvent.Parameter args)
    {
        if(!enabled)
            return;

        if((GameEvent.Types)args.Type == Type)
        {
            OnEvent?.Invoke();
        }
    }
        
    #endregion
}