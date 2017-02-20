using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour {

    private ObjectToMousePosition objectPosition;
    [SerializeField]
    private float snapDistance;
    private float distance;
    public bool snapping;

    void Awake()
    {
        objectPosition = GameObject.Find("ScriptHolder").GetComponent<ObjectToMousePosition>();
    }

    void LateUpdate ()
    {
        distance = Vector3.Distance(MousePosition.position.mousePosition, transform.position);
        
        if (objectPosition.GetSetTargetObject != null && distance <= snapDistance)
        {
            snapping = true;
            objectPosition.GetSetTargetObject.transform.position = transform.position;
            objectPosition.GetSetTargetObject.transform.rotation = transform.rotation;
        }
        else
        {
            snapping = false;
        }
	}
}
