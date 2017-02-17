using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour {

    [SerializeField]
    private ObjectToMousePosition objectPosition;
    [SerializeField]
    private float snapDistance;
    private float distance;
    private PlaceTarget snapping;


    void Start()
    {
        snapping = GameObject.Find("ScriptHolder").GetComponent<PlaceTarget>();
    }
    void LateUpdate ()
    {
        distance = Vector3.Distance(MousePosition.position.mousePosition, transform.position);

        if (objectPosition.GetSetTargetObject != null && distance < snapDistance)
        {
            snapping.GetSetSnapping = true;

            objectPosition.GetSetTargetObject.transform.position = transform.position;
            objectPosition.GetSetTargetObject.transform.rotation = transform.rotation;
        }
        else
        {
            snapping.GetSetSnapping = false;
        }
	}
}
