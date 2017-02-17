using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTarget : MonoBehaviour {

    private ObjectToMousePosition target;
    public bool snapping;

    void Awake()
    {
        target = GameObject.Find("ScriptHolder").GetComponent<ObjectToMousePosition>();
    }

	void FixedUpdate ()
    {
        if (snapping)// Waarom?
        {
            if (InputManager.input.IsKeyDownOn(InputManager.keyActions.place) && target.GetSetTargetObject != null)
            {
                target.GetSetTargetObject = null;
            }
        }
	}
}
