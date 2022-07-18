using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateStats : MonoBehaviour
{
    // Start is called before the first frame update
    public int agility = 0;
    public int intelligence = 0;
    public int strength = 0;
    public int statsPool = 20;
    public int statsPool1 = 0;
    public int statsPool2 = 0;

    private float rangeMaximum = 10;
    void Start()
    {

        agility = Random.Range(0, statsPool);
        intelligence = Random.Range(0, statsPool1);
        strength = Random.Range(0, statsPool2);
        statsPool1 = statsPool - agility;
        statsPool2 = statsPool1 - intelligence;

    }

    // Update is called once per frame
    void Update()
    {
        float randomNumber = Random.Range(0, rangeMaximum);
        if (randomNumber == 1)
            Debug.Log("The number was exactly one");
        else if (randomNumber > 3)
            Debug.Log("The number was greater than three");
        else if (randomNumber != 4)
            Debug.Log("The number was less than three or greater than 5");
        else if (randomNumber < 5)
            Debug.Log("The number was greater than one and less than 5");


        Debug.Log("Agility = " + agility);
        Debug.Log("intelligence = " + intelligence);
        Debug.Log("strength = " + strength);
        Debug.Log("statsPool = " + statsPool);
    }
}
