using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToSleep : MonoBehaviour {

    [SerializeField]
    private MenuScript nightUI;
    [SerializeField]
    private Canvas selectedUI;

	void Update () {
        {
            nightUI.ScreenUpdate(selectedUI);
        }
	}
}
