using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    [SerializeField]
    private ObjectToMousePosition target;

	public void Instantiate(GameObject item)
    {
        if(target.GetSetTargetObject == null)
        {
            GameObject instant = Instantiate(item, MousePosition.position.mousePosition, Quaternion.identity);
            instant.transform.parent = BuildLayer.currentLayer.transform;
            target.GetSetTargetObject = instant;
        }
    }
}
