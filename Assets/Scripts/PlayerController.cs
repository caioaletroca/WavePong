using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    #region Public Variables
    public PlayerModelScriptableObject model;

    #endregion

    #region Private Variables;

    private Rigidbody2D rb;
    private Gamepad gamePad;
    private Vector2 Direction = Vector2.zero;

    #endregion

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gamePad = Gamepad.current; 
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, Direction.y * model.Velocity * Time.fixedDeltaTime);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Direction = context.ReadValue<Vector2>();
    }
}
