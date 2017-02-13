using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

	public void Instantiate(GameObject item)
    {
        Instantiate(item,transform.position, Quaternion.identity);
    }
}
