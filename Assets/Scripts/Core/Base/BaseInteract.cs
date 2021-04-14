using System;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Defines a base interactible class
/// </summary>
public class BaseInteract : MonoBehaviour
{
    #region Types

    /// <summary>
    /// Event with parameters
    /// </summary>
    [Serializable]
    public class InteractTrigger2DEvent : UnityEvent<Collider2D> { }

    /// <summary>
    /// Event with parameters
    /// </summary>
    [Serializable]
    public class InteractCollision2DEvent : UnityEvent<Collision2D> { }

    #endregion

    #region Public Properties

    /// <summary>
    /// The layers allowed to interact with the game object
    /// </summary>
    [Tooltip("The layers allowed to interact with the game object.")]
    public LayerMask Layers;

    #endregion

    #region Unity Methods

    private void Reset()
    {
        Layers = LayerMask.NameToLayer("Everything");
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override bool Equals(object other)
    {
        return base.Equals(other);
    }

    public override string ToString()
    {
        return base.ToString();
    }

    #endregion
}
