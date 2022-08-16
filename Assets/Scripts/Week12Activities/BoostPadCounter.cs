using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace MitchellGascoigne
{
    public class BoostPadCounter : MonoBehaviour
    {
        // For our Event system we need these things:
        // Announce event at particular times or when a particular collision occurs, etc...
        // We want to make sure our UI is LISTENING for the Event
        // When the Event is announced, we want to update our UI

        [SerializeField] private TextMeshProUGUI boostPadCounter;
        [SerializeField] private int boostPadCount = 0;

        private void OnEnable()
        {
            BoostPadEventManager.OnBoostPadActivation += IncreaseBoostPadCount;
        }

        private void OnDisable()
        {
            BoostPadEventManager.OnBoostPadActivation -= IncreaseBoostPadCount;
        }

        private void IncreaseBoostPadCount()
        {
            boostPadCount++;
            boostPadCounter.text = "Boost Pads Used: " + boostPadCount;
        }
    }

}

