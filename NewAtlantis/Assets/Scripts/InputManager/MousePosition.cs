using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour {

    public static MousePosition position;
    public Vector3 mousePosition;
    [Header("Camera")]
    [SerializeField]
    private Camera buildCamera;

    void Awake()
    {
        position = this;
    }

	void FixedUpdate ()
    {
        if (!buildCamera.enabled)
        {
            return;
        }
        Ray ray = buildCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            mousePosition = hit.point;
        }
    }
}
