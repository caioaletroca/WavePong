using System;
using UnityEngine.Events;

/// <summary>
/// Creates a Game Events base
/// </summary>
namespace GameEvent
{
    /// <summary>
    /// Parameters for the event
    /// </summary>
    public class Parameter
    {
        public int Type;
    }

    /// <summary>
    /// Unity event
    /// </summary>
    [Serializable]
    public class Event : UnityEvent<Parameter> { }
}