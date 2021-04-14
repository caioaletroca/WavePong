using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Handles collision trigger interactions on game objects
/// </summary>
[RequireComponent(typeof(Collider2D))]
public class InteractOnTrigger2D : BaseInteract
{
    #region Public Properties

    /// <summary>
    /// The event fired when the interaction happens
    /// </summary>
    public UnityEvent OnTrigger;

    /// <summary>
    /// The event fired when the interaction happens with parameters
    /// </summary>
    public InteractTrigger2DEvent OnTriggerParameter;

    #endregion

    #region Unity Methods

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!enabled)
            return;

        if (Layers.Contains(collision.gameObject))
        {
            OnTrigger?.Invoke();
            OnTriggerParameter?.Invoke(collision);
        }
    }

    private void OnDrawGizmos()
    {
        if (!enabled)
            return;

        Gizmos.DrawIcon(transform.position, "InteractionTrigger", false);
    }

    #endregion
}
