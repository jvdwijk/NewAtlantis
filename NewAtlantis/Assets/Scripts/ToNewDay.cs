﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDay : MonoBehaviour {

    [SerializeField]
    private MenuScript dayUI;
    [SerializeField]
    private Canvas selectedUI;


    public void StartDay()
    {
        dayUI.ScreenUpdate(selectedUI);
        SaveLoad.Load();
    }
}
