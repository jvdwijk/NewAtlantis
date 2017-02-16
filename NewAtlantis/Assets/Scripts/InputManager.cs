using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager input;

    public List<ButtonMapping> buttonMap = new List<ButtonMapping>();

    public enum keyActions { forward, backward, left, right, action }

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
