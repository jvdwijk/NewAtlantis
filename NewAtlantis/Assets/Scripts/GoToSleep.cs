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
        if (InputManager.input.OnKeyDown(InputManager.keyActions.action) && distance <= 3)
        {
            nightUI.ScreenUpdate(selectedUI);
            Game.mainBase = GameObject.Find("Layers");
            SaveLoad.Save();
        }
    }
}
