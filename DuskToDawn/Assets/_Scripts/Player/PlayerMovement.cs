using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private InputAction MovementControlls;

    private void OnEnable()
    {
        MovementControlls.Enable();
    }

    private void OnDisable()
    {
        MovementControlls.Disable();
    }
}
