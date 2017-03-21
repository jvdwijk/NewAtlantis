using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour {

    private int count;
    private bool uiEnabled = false;

    void Awake()
    {
        SaveLoad.Load();
    }

    
}
