using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    /*private float moveHorizontal;
    private float moveVertical;
    private bool mouseClick;

    private void FixedUpdate()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        mouseClick = Input.GetButton("MouseClick");
    }    

    public float GetSetVertical
    {
        get {return moveVertical; }
        set {moveVertical = value; }
    }

    public float GetSetHorizontal
    {
        get { return moveHorizontal; }
        set { moveHorizontal = value; }
    }

    public bool GetSetMouseClick
    {
        get { return mouseClick; }
        set { mouseClick = value; }
    }*/

    public static InputManager inputManager;

    public KeyCode[] buttons;
    public string[] buttonNames;
    public string[] buttonKeys;

    void Awake()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i] = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(buttonNames[i], buttonKeys[i]));
        }
    }
}
