using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToSleep : MonoBehaviour {

    [SerializeField]
    private MenuScript nightUI;
    [SerializeField]
    private Canvas selectedUI;

	void Update () {
		if(/*Input.GetKeyUp(InputManager.input.buttonMap[(int)InputManager.keyActions.action].buttonKey)*/Input.GetKeyUp(KeyCode.E))
        {
            nightUI.ScreenUpdate(selectedUI);
        }
	}
}
