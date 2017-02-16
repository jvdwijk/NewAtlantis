using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTarget : MonoBehaviour {

    [SerializeField]
    private ObjectToMousePosition target;
    public static bool snapping = false;

	void FixedUpdate ()
    {
        print(snapping);
        if (Input.GetKeyUp(InputManager.input.buttonMap[(int)InputManager.keyActions.place].buttonKey) && target.GetSetTargetObject != null)
        {
            print(snapping);
            if (snapping)
            {
                target.GetSetTargetObject = null;
            }
        }
	}
}
