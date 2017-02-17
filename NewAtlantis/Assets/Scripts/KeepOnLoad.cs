using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepOnLoad : MonoBehaviour {

    public static KeepOnLoad thisScript;

    void Awake()
    {
        if (thisScript == null)
        {
            DontDestroyOnLoad(gameObject);
            thisScript = this;
        }
        else if (thisScript != this)
        {
            Destroy(gameObject);
        }
    }
}
