using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToSleep : MonoBehaviour {

    [SerializeField]
    private MenuScript nightUI;
    [SerializeField]
    private Canvas selectedUI;
    private float distance;
    [SerializeField]
    private GameObject player;

	void Update () {

        distance = Vector3.Distance(player.transform.position , transform.position);

        if (Input.GetKeyUp(InputManager.input.buttonMap[(int)InputManager.keyActions.action].buttonKey) && distance <= 3)
        {
            nightUI.ScreenUpdate(selectedUI);
        }
    }
}
