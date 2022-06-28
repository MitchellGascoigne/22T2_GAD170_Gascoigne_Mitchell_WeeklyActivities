using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopTester : MonoBehaviour
{

    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        for (int i = 0; i < 100; i++)
        {
            counter++; // increase the counter up by 1
            Debug.Log("Counter is now at: " + counter);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
