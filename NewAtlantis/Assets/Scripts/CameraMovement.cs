using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	void FixedUpdate () {
		if(InputManager.input.OnKey(InputManager.keyActions.left))
        {
            MoveCam(new Vector2(-1,0));
        }
        else if (InputManager.input.OnKey(InputManager.keyActions.right))
        {
            MoveCam(new Vector2(1, 0));
        }
        if (InputManager.input.OnKey(InputManager.keyActions.forward))
        {
            MoveCam(new Vector2(0, 1));
        }
        else if (InputManager.input.OnKey(InputManager.keyActions.backward))
        {
            MoveCam(new Vector2(0,-1));
        }
    }

    private void MoveCam(Vector2 direction)
    {
        transform.position += new Vector3(direction.x, 0, direction.y);
    }
}
