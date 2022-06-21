using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// I’m so cool - 8mins
// Using the returned value from Conversions log out the temperature followed by a messaged based on the following conditions:
// Temp less than 0 then Freezing weather
// Temp 0-10 then Very Cold weather
// Temp 10-20
// If it’s below 13 or it’s exactly 14 debug it’s a bit cool.
//Otherwise it’s cold weather.
//Temp 30 -40
//If it is below 35 debug out nice qld day
//Else if it’s below 37 but more than 35 debug out getting warmer.
//Else it’s hot.
//Temp greater than or equal 40 then Its Very Hot



public class WeekFourActivitiesTemp : MonoBehaviour
{
    // Start is called before the first frame update
    private float Fahrenheit = 150;
    private float celcius;
        void Start()
    {
        celcius = (Fahrenheit - 32) * 5 / 9;
        Debug.Log("The Temperature in celcius is: " + celcius);

        if (celcius < 0)
            Debug.Log("It is freezing!!!");
        else if (celcius > -1 && celcius < 11)
            Debug.Log("It is very cold!");
        else if (celcius > 10 && celcius <= 14)
            Debug.Log("It is a bit chilly.");
        else if (celcius > 14 && celcius < 20)
            Debug.Log("There's a cool wind blowing...");
        else if (celcius > 19 && celcius < 30)
            Debug.Log("Temperature is normal.");
        else if (celcius > 29 && celcius < 35)
            Debug.Log("Nice QLD day.");
        else if (celcius > 34 && celcius < 37)
            Debug.Log("Quite warm out today.");
        else if (celcius > 36 && celcius < 41)
            Debug.Log("It's hot today!");
        else if (celcius > 39)
            Debug.Log("It is scorching!!!");
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
