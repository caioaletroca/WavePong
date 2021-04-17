using UnityEngine;

/// <summary>
/// Creates a Base Scene template for Controllers
/// </summary>
public class BaseSceneController : MonoBehaviour {
    #region Public Properties

    [Tooltip("Fires game event changes")]
    public GameEvent.Event OnGameEvent;

    #endregion
}