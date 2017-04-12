using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadButton : MonoBehaviour {

    private GameObject[] buttons;
    [SerializeField] //Choose what canvas you want the buttons on.
    private Canvas parentCanvas;
    [SerializeField]
    private GameObject buttonPrefab;

	void Start () {
        for (int i = 0; i < 5; i++)
        {

            //CreateButton.CreateButton(parentCanvas, position, method);
            GameObject button = Instantiate(buttonPrefab) as GameObject;
            button.transform.SetParent(parentCanvas.transform, false);
        }
	}
}
