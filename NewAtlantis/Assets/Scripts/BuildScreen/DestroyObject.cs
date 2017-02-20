using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

    private bool demolishMode;
    [SerializeField]
    private ObjectToMousePosition selectedTarget;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && demolishMode)
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && !hit.collider.gameObject.CompareTag("Ground"))
            {
                Destroy(hit.collider.transform.parent.gameObject);
            }
        }
    }

    /// <summary>
    /// function to cancel building
    /// </summary>
	public void Cancel()
    {
        Destroy(selectedTarget.GetSetTargetObject);
        selectedTarget.GetSetTargetObject = null;
    }

    /// <summary>
    /// function to select object with raycasts 
    /// </summary>
    public void Demolish()
    {
        if (demolishMode)
            demolishMode = false;
        else
            demolishMode = true;
    }

    /// <summary>
    /// Destroy selected object
    /// </summary>
    private void Destroy(GameObject target)
    {
        DestroyObject(target);
    }
}
