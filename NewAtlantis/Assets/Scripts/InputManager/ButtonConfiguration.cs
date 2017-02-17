using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonConfiguration : MonoBehaviour {

    public Text[] buttonLabel;
    public InputManager.keyActions remapAction;

    private bool shouldRemap;
    private int maxJoysticks = 1;
    private int maxAxis = 10;

	void Start () {
        InputManager.input.LoadConfiguration();
        shouldRemap = false;

        Reload();
	}

	void Update () {
        if (shouldRemap)
        {

            //detect button presses
            for (int action = (int)KeyCode.Backspace; action <= (int)KeyCode.Joystick1Button10; action++)
            {
                if(Input.GetKey((KeyCode)action))
                {
                    var temInput = InputManager.input.buttonMap[(int)remapAction];
                    temInput.buttonKey = (KeyCode)action;
                    temInput.axis = "";
                    temInput.axisState = InputManager.axisState.none;
                    temInput.buttonName = temInput.buttonKey.ToString();
                    buttonLabel[(int)remapAction].text = temInput.buttonName;
                    InputManager.input.buttonMap[(int)remapAction] = temInput;
                    shouldRemap = false;
                }
            }

            // detect axis
            for(int joystick = 1; joystick <= maxJoysticks; joystick++)
            {
                for (int axis = 1; axis <= maxAxis; axis++)
                {
                    if (Input.GetAxis("Joystick" + joystick + "Axis" + axis) > 0.1)
                    {
                        var temInput = InputManager.input.buttonMap[(int)remapAction];
                        temInput.buttonKey = KeyCode.None;
                        temInput.axis = "Joystick" + joystick + "Axis" + axis;
                        temInput.axisState = InputManager.axisState.positive;
                        temInput.buttonName = "Joystick" + joystick + "Axis" + axis + "+";
                        buttonLabel[(int)remapAction].text = temInput.buttonName;
                        InputManager.input.buttonMap[(int)remapAction] = temInput;
                        shouldRemap = false;
                    }

                    else if (Input.GetAxis("Joystick" + joystick + "Axis" + axis) < -0.1)
                    {
                        var temInput = InputManager.input.buttonMap[(int)remapAction];
                        temInput.buttonKey = KeyCode.None;
                        temInput.axis = "Joystick" + joystick + "Axis" + axis;
                        temInput.axisState = InputManager.axisState.negative;
                        temInput.buttonName = "Joystick" + joystick + "Axis" + axis + "-";
                        buttonLabel[(int)remapAction].text = temInput.buttonName;
                        InputManager.input.buttonMap[(int)remapAction] = temInput;
                        shouldRemap = false;
                    }
                }
            }
        }
    }

    public void Remap(int action)
    {
        remapAction = (InputManager.keyActions)action;
        buttonLabel[action].text = "press a key";
        shouldRemap = true;
    }

    public void Reload()
    {
        for (int action = (int)InputManager.keyActions.forward; action <= (int)InputManager.keyActions.action; action++)
        {
            buttonLabel[action].text = InputManager.input.buttonMap[action].buttonName;
        }
    }
}
