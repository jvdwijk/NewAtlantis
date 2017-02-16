using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager input;
    public ButtonMapping[] buttonMap;
    public enum keyActions { forward, backward, left, right, place, action }

    void Awake()
    {
        input = this;
    }

    public void SaveConfiguration()
    {
        for (int action = (int) keyActions.forward; action <= (int) keyActions.action; action++)
        {
            PlayerPrefs.SetInt("Controls_" + action, (int)buttonMap[action].buttonKey);
        }
    }

    public void LoadConfiguration()
    {
        for (int action = (int)keyActions.forward; action <= (int)keyActions.action; action++)
        {
            buttonMap[action].buttonKey = (KeyCode)PlayerPrefs.GetInt("Controls_" + action);
        }
    }
}
