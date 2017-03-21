using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTarget : MonoBehaviour {

    private SnapObject snapObject;
    private ObjectToMousePosition target;

    void Awake()
    {
        snapObject = gameObject.GetComponent<SnapObject>();
        target = GameObject.Find("ScriptHolder").GetComponent<ObjectToMousePosition>();
    }

	void Update ()
    {
        if (snapObject.snapping)// Waarom?
        {
            if (InputManager.input.OnKeyDown(InputManager.keyActions.place))
            {
                snapObject.enabled = false;
                target.GetSetTargetObject = null;
                this.enabled = false;
            }
        }
	}
}
