using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

    [SerializeField]
    private ObjectToMousePosition selectedTarget;


    /// <summary>
    /// function to cancel building
    /// </summary>
	public void Cancel()
    {
        print(selectedTarget.GetSetTargetObject);
        //Destroy(selectedTarget.GetSetTargetObject);
    }

    /// <summary>
    /// function to select object with raycasts 
    /// </summary>
    public void Demolish()
    {

    }

    /// <summary>
    /// Destroy selected object
    /// </summary>
    private void Destroy(GameObject target)
    {
        DestroyObject(target);
    }
}
