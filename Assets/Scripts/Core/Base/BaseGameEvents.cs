using System;
using UnityEngine.Events;

/// <summary>
/// Creates a Game Events base
/// </summary>
namespace GameEvent
{
    public class Parameter
    {
        public int Type;
    }

    [Serializable]
    public class Event : UnityEvent<Parameter> { }
}