using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{
    public class CharacterColourChanger : MonoBehaviour
    {
        // We need a reference to the character we will change the coulour of
        [SerializeField] private MeshRenderer simpleCharacterRenderer;


        void Update()
        {
            // We need to change the character's colour IF it has an X position < or > than 0
            if (simpleCharacterRenderer.gameObject.transform.position.x > 0)
            {
                simpleCharacterRenderer.material.color = Color.green;
            }
            else
            {
                simpleCharacterRenderer.material.color = Color.red;
            }
            // Write a class that stores data of names of some of your favourite things(superheroes, fruits, songs, colours… an array of names that can go in strings) in an Array and also a List
            //Use a method to output the contents of those collections in the Console
            //Add a new piece of data at runtime(Array = new array… List = List.Add) (i.e. in the Update() loop)
            //Use a method to output the contents of those collections in the Console again
    }

}
}