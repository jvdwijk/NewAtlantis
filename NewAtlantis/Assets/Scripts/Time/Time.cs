using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour {

    [Header("Time in hours")] //Define at what hour you want to start and end the day.
    [SerializeField] 
    private int startTime;
    [SerializeField] 
    private int endTime;
    [Header("Time in secconds")] //Define how long it takes to update the time of your game.
    [SerializeField] 
    private float timeUpdate;

    //Make it static so you can use it in your other scripts.
    static public int hours;
    static public int minutes;
    static public int totalMinutes;

    private void Start()
    {
        totalMinutes = startTime * 60;
        StartCoroutine(TimeProgress());
    }

    /// <summary>
    /// calculate what your new time is, until the day ends.
    /// </summary>
     IEnumerator TimeProgress()
    {
        while (hours < endTime)
        {
            totalMinutes += 10;
            hours = totalMinutes / 60;
            minutes = totalMinutes - (hours * 60);

            yield return new WaitForSeconds(timeUpdate);
        }  
    }
}