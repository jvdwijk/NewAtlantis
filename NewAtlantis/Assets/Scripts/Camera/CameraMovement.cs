using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    private float verticalInput;
    private float horizontalInput;

    void GetInput()
    {
        verticalInput = InputManager.input.GetAxis(InputManager.keyActions.forward) - InputManager.input.GetAxis(InputManager.keyActions.backward);
        horizontalInput = InputManager.input.GetAxis(InputManager.keyActions.right) - InputManager.input.GetAxis(InputManager.keyActions.left);
    }

    void Update()
    {
        GetInput();
        gameObject.transform.Translate(horizontalInput, verticalInput, 0);
    }
}
