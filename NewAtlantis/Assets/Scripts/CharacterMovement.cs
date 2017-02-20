using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CharacterMovement : MonoBehaviour {

    public float inputDelay = 0.1f;
    public float verticalVelocity = 12;
    public float horizontalVelocity = 12;
    
    private float verticalInput;
    private float horizontalInput;
    private Rigidbody rigidBody;
    private Vector3 step;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        verticalInput = horizontalInput = 0;
    }

    void GetInput()
    {
        verticalInput = InputManager.input.GetAxis(InputManager.keyActions.forward) - InputManager.input.GetAxis(InputManager.keyActions.backward);
        horizontalInput = InputManager.input.GetAxis(InputManager.keyActions.right) - InputManager.input.GetAxis(InputManager.keyActions.left);
    }
    void Update()
    {
        GetInput();
    }

    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        if (Mathf.Abs(verticalInput) > inputDelay || Mathf.Abs(horizontalInput) > inputDelay)
        {
            step = Vector3.Normalize(new Vector3 (horizontalInput, 0, verticalInput));
            step = transform.forward * step.z * verticalVelocity + transform.right * step.x * horizontalVelocity;
            step.y = rigidBody.velocity.y;
            rigidBody.velocity = step;
        }
        else
        {
            rigidBody.velocity = new Vector3(0, step.y, 0);
        }
    }
}
