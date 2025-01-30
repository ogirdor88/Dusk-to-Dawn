using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 moveDirection;
    public NewControls movePlayer;
    private InputAction movement;

    [SerializeField]
    private float moveSpeed;

    Vector3 mousePosition;
    Vector3 lookDirection;


    private void Awake()
    {
        movePlayer = new NewControls();
    }

    private void OnEnable()
    {
        movement = movePlayer.Player.Movement;
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }


    private void Update()
    {
        moveDirection = movement.ReadValue<Vector2>();
        transform.position += new Vector3(moveDirection.x, 0, moveDirection.y) * Time.deltaTime * moveSpeed;

        //get the mouse postion on the screen and have the player turn towards it
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lookDirection = mousePosition - transform.position;
        lookDirection.y = 0; // Optional: Flatten the y-axis to prevent looking up/down
        transform.LookAt(transform.position + lookDirection);

    }
}
