using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne { }
public class Week8Activities : MonoBehaviour
{
    /// <summary>
    /// My fruit enumerator
    /// </summary>
    public enum Fruit
    {
        Apple,
        Banana,
        Orange,
        Strawberry,
        Mango,
        Kiwi,
        Watermelon,
        Peach
    }

    public Fruit favouriteFruitOfAaron = Fruit.Mango;
    public Fruit favouriteFruitOfMitch = Fruit.Banana;
    public Fruit favouriteFruitOfRachelle = Fruit.Watermelon;
    public Fruit favouriteFruitOfOwen = Fruit.Kiwi;
    public Fruit favouriteFruitOfCallum = Fruit.Mango;
    public Fruit favouriteFruitOfChester = Fruit.Watermelon;


    public Fruit[] myFruitBasket = new Fruit[10];

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < myFruitBasket.Length; i++)
        {
            CheckBasketWithSwitch();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // favouriteFruit = Fruit.Orange;
    }

    private void CheckBasketwithIfElse()
    {
        for (int i = 0; i < myFruitBasket.Length; i++)
        {
            if (myFruitBasket[i] == favouriteFruitOfAaron)
                Debug.Log("This is Aaron's favourite fruit!");
            if (myFruitBasket[i] == favouriteFruitOfCallum)
                Debug.Log("This is Callum's favourite fruit!");
        }
    }
    private void CheckBasketWithSwitch()
    {
        for (int i = 0; i < myFruitBasket.Length; i++)
        {
            switch (myFruitBasket[i])
            {
                case Fruit.Apple:
                    Debug.Log("Apple!");
                    // logic
                    break;
                case Fruit.Banana:
                    // logic
                    Debug.Log("Banana!");
                    break;                    
                case Fruit.Orange:
                    // logic
                    Debug.Log("Orange!");
                    break;         
                case Fruit.Strawberry:
                    // logic
                    Debug.Log("Strawberry!");
                    break;
                default:
                    // logic if no other case returned true (i.e FAIL)
                    Debug.Log("Some other Fruit!");
                    break;
            }
        }
    }
}
