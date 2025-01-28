using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private InputAction MovementControlls;
    private Vector2 moveDirection;

    private void OnEnable()
    {
        MovementControlls.Enable();
    }

    private void OnDisable()
    {
        MovementControlls.Disable();
    }

    private void Update()
    {
        moveDirection = MovementControlls.ReadValue<Vector2>();
    }
}
