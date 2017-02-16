using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour {

    [SerializeField]
    private ObjectToMousePosition objectPosition;
    [SerializeField]
    private float snapDistance;
    private float distance;

    void LateUpdate ()
    {
        distance = Vector3.Distance(MousePosition.position.mousePosition, transform.position);

        if (objectPosition.GetSetTargetObject != null && distance < snapDistance)
        {
            PlaceTarget.snapping = true;
            objectPosition.GetSetTargetObject.transform.position = transform.position;
            objectPosition.GetSetTargetObject.transform.rotation = transform.rotation;
        }
        else
        {
            PlaceTarget.snapping = false;
        }
	}
}
