using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameGenerator : MonoBehaviour
{
    [Header("List of Favourite Things")]
    private List<string> favouriteThings = new List<string>(); // a list of all favourite things for us to use.
                                                               // Start is called before the first frame update
    private void Awake()
    {
        CreateList();
    }


    public void CreateList()
    {
        // So here we would ideally want to be able to add some names to our favourite things.
        favouriteThings.Add("Spiderman");
        favouriteThings.Add("WaterMelon");
        favouriteThings.Add("Gangnam Style");
        favouriteThings.Add("Green");

    }

    public void SetFavouriteList(NameGenerator List)
    {
        List.favouriteThings = favouriteThings;

        Debug.Log(List);
    }
}