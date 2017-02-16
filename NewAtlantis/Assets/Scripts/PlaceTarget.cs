using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTarget : MonoBehaviour {

    [SerializeField]
    private ObjectToMousePosition target;
    public static bool snapping;

	void FixedUpdate ()
    {
        if (Input.GetKeyUp(InputManager.input.buttonMap[(int)InputManager.keyActions.action].buttonKey) /*&& target.GetSetTargetObject != null*/)
        {
            //if (snapping)
            //{
                //target.GetSetTargetObject = null;
            //}
        }
	}
}
