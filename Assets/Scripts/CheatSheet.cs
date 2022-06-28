using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{ 
public class CheatSheet : MonoBehaviour
    {
        // TODO: Set up templates for class/variable/function/if-else/for loop

        // To declare a variable, we need:
        // - a variable to declare, for example: high score
        // accessModifier Type theNameYouGiveTheVariable
        // Note: TheNameYouGiveTheVariable must use lowerCamelCase
        // For Example:

        public int highScore;
        public int score;
        public List<GameObject> enemies = new List<GameObject>();

        //To declare a method, we need:
        // accessModifier ReturnType TheNameYoiuGiveTheMethod
        // Note: TheNameYouGiveTheMethod must use Pascal or UpperCamelCase
        // For example, a method that resets the high score:

        public void ScoreReset()
        {
            //This is our Template!
           score = 0;
        }

        public void AddScore(int amount)
        {
            score =score + amount;
            // To declare an "if statement", we use this syntac:
            // (note; it needs to be inside a method)
            // if ([value] [operator] [value]{}
            // For Example, to check if our score is higher than our high score, to save a new score, we do ...

            score = 10;
            highScore = 5;

            if (score > highScore)
            {
                highScore = score;
                // Now, highScore is equal to 10
            }

        }
        public void ResetGame()
        {
            //To declare a "for loop", we use this syntax:
            //for (int i = 0; i < length i++)
            //{
            //
            //}
            //
            // missing
            //
            //
            // For example, if we needed to reset four enemies, we can write:
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[1].transform.position = Vector3.zero;
                // enemies[i].health = 100;
                // enemies[i].weapon = GetRandomWeapon();
            }
            // The logic behind a 'For Loop' is that it will run the code inside, as many times as you tell it to.
            // The above loop will run once per enemy.
            // On each iteration, the code inside will execute.
        }
    }

    // To declare a class:
    // [accessModifier] [the word "class"] [ClassName]
    //{
    //
    //}
    // For example:

    public class ExampleClass : MonoBehaviour
    {
        // This class can be accessed (i.e seen) by other classes becasue it is public.
        // You cannot make a private class. (In general.)
        CheatSheet sheet;
        
        void Start()
        {
            sheet.highScore = 10;
        }

    }

    // Using Private and Public
    public class GameController : MonoBehaviour
    {
        public ScoreSystem scoreSystem;
    }

    public class Enemy : MonoBehaviour
    {
        GameController controller;

        public void BecomeDead()
        {
            controller.scoreSystem.IncreaseScore();
        }
    }

    public class ScoreSystem : MonoBehaviour
    {
        private int highScore = 0;

        public void IncreaseScore()
        {
            highScore += 10;
        }
    }


}
