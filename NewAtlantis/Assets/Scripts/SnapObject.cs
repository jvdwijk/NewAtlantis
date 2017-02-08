using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour {

    [SerializeField] private ObjectToMousePosition objectPosition;
    private float distance;
    [SerializeField] private float snapDistance;

    void LateUpdate ()
    {
        distance = Vector3.Distance(MousePosition.position.mousePosition, transform.position);

        if (objectPosition.GetSetTargetObject != null && distance < snapDistance)
        {
            objectPosition.GetSetTargetObject.transform.position = transform.position;
            objectPosition.GetSetTargetObject.transform.rotation = transform.rotation;
        }
	}
}
