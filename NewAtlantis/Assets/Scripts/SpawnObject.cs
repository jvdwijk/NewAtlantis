using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    [SerializeField]
    private ObjectToMousePosition target;

	public void Instantiate(GameObject item)
    {
        GameObject instant = Instantiate(item, MousePosition.position.mousePosition, Quaternion.identity);
        target.GetSetTargetObject = instant;
    }
}
