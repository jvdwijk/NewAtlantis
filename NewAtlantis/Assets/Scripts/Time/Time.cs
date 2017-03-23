using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour {

    static int minutes = 290;
    static int hours;

    public void Start()
    {
        StartCoroutine(TimeProgress());
    }

     IEnumerator TimeProgress()
    {
        while (hours < 25)
        {
            minutes += 10;
            hours = minutes / 60;
            yield return new WaitForSeconds(10);
        }  
    }
}