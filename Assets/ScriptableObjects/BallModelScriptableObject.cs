using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Stores the Ball data
/// </summary>
[CreateAssetMenu(fileName = "BallModel", menuName = "Ball Model")]
public class BallModelScriptableObject : ScriptableObject
{
    [Tooltip("Current Ball velocity")]
    public Vector2 Velocity = Vector2.zero;

    [Tooltip("The amount of randomness applied to the Ball collision on Players")]
    [Range(0, 1f)]
    public float Randomness = 0;
}
