using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTarget : MonoBehaviour {

    [SerializeField]
    private ObjectToMousePosition target;
    public bool GetSetSnapping { get; set; }

	void LateUpdate ()
    {
        print(GetSetSnapping);
        if (InputManager.input.IsKeyDownOn(InputManager.keyActions.place) && target.GetSetTargetObject != null)
        {
            if (GetSetSnapping)
            {
                target.GetSetTargetObject = null;
            }
        }
	}
}
