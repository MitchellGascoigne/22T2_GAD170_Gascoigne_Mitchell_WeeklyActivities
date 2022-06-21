using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script / Function, that calculates the Electricity bill of a given customer, Log out their : customer ID(random ID), Name, create a random amount of Units between 100 and 700 and calculate their bill based on the following charges:
// First 200 units, @ $1.20
// Every unit above 200 and between 350 units @ $1.50
// Every unit above that @ $1.80

// Test Data:
// Customer id: 1001
// Customer Name: James
// Units used: 650
// Expected Output :
// Customer IDNO : 1001
// Customer Name :James
// unit Consumed : 650
// Amount Charged @ $1.20 = $240
// Amount Charged @ $1.50 = $225
// Amount Charged @ $1.80 = $540
// Net Bill: $1005.00


public class WeekFourActivitiesExtra : MonoBehaviour
{
    // Start is called before the first frame update

    private int electricityBill;
    private int customerID = Random.Range(1000, 10000);

    void Start()

    {
        Debug.Log("Customer I.D: " + customerID);
        Debug.Log("Name: James Mcmooshru");




        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
