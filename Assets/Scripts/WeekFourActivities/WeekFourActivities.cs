using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekFourActivities : MonoBehaviour
{
    // Start is called before the first frame update
    private int LeapYearTest = 2021;

    void Start()
    {
        if (LeapYearTest % 4 == 0)
            Debug.Log(LeapYearTest + " is a leap year.");
        else
            Debug.Log(LeapYearTest + " is not a leap year.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
