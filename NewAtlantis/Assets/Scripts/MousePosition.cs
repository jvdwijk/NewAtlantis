using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour {

    public static MousePosition position;
    public Vector3 mousePosition;

	void FixedUpdate ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            mousePosition = hit.point; 
        }
    }
}
