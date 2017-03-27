using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour {

    [SerializeField]
    private Text uiText;

	void Update()
    {
        if (Time.hours > 24) //if day passed
        {
            UpdateClockUI(24);
        }
        else //if on same day
        {
            UpdateClockUI(0);
        }
    }

    private void UpdateClockUI(int lessTime)
    {
        //if clock strikes an hour (example: 12:00, 13:00)
        if (Time.minutes != 0)
        {
            uiText.text = (Time.hours - lessTime) + ":" + Time.minutes;
        }
        else
        {
            uiText.text = (Time.hours - lessTime) + ":0" + Time.minutes;
        }
    }
}
