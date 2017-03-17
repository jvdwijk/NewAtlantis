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

	void LateUpdate ()
    {
        if (!snapObject.snapping || !InputManager.input.OnKeyDown(InputManager.keyActions.place) || target.GetSetTargetObject == null)
        {
            return;
        }
        target.GetSetTargetObject = null;
        this.enabled = false;
        snapObject.enabled = false;
    }
}
