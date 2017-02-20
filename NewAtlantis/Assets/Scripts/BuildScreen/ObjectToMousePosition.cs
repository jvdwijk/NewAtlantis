using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToMousePosition : MonoBehaviour
{
    [SerializeField]
    private GameObject targetObject;

    public GameObject GetSetTargetObject
    {
        get
        { return targetObject; }
        set
        { targetObject = value; }
    }
    void Update()
    {
        if (targetObject != null)
        {
            targetObject.transform.position = MousePosition.position.mousePosition;
        }
    }
}