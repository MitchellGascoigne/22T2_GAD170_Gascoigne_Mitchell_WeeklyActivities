using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{
    public class WeekTwoActivities : MonoBehaviour
    {
        public int agility = 0;
        public int intelligence = 0;
        public int strength = 0;
        public int statsPool = 20;
        public int statsPool1 = 0;
        public int statsPool2 = 0;

        // Information about my favourite game (name, hours played and cost)
        private string favouriteGame = "Witcher 3";
        private int hoursPlayed = 100;
        private float costOfGame = 80f;

        private float randomNumber = Random.Range(0, 10);

        // Start is called before the first frame update
        void Start()
        {
            // / is divide
            float dollarsPerHour;
            dollarsPerHour = costOfGame / hoursPlayed;
            Debug.Log("My favourite game is " + favouriteGame + " I have played it for " + hoursPlayed + " hours, and it cost me $" + costOfGame + " Therefore, my value of dollars per hour is: " + dollarsPerHour);
        }
        // Update is called once per frame
        void Update()
        {
            if (randomNumber == 1)
                Debug.Log("The number was exactly one");
            else if (randomNumber > 3)
                Debug.Log("The number was greater than three");
            else if (randomNumber != 4)
                Debug.Log("The number was less than three or greater than 5");
            else if (randomNumber < 5)
                Debug.Log("The number was greater than one and less than 5");
        }

        public void Character() 
        {
            agility = Random.Range(0,statsPool);
            intelligence = Random.Range(0, statsPool1);
            strength = Random.Range(0, statsPool2);   
            statsPool1 = statsPool - agility;
            statsPool2 = statsPool1 - intelligence;

            Debug.Log("Agility = " + agility);
            Debug.Log("intelligence = " + intelligence);
            Debug.Log("strength = " + strength);
            Debug.Log("statsPool = " + statsPool);

            //Finally, each time we assign a random value, let’s remove that from our stat pool; i.e. strength gets the random number 7;
            //we take this away from our statpool, there are now 13 stat points left, agility now gets a random number between 0 and 13.

        }
    }
}
