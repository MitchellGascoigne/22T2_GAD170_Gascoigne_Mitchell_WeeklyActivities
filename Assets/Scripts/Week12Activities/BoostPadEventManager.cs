using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{

    public class BoostPadEventManager : MonoBehaviour
    {
        public delegate void BoostPadActivationAction();
        public static event BoostPadActivationAction OnBoostPadActivation;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if(OnBoostPadActivation != null)
                {
                    OnBoostPadActivation();
                }
            }
        }

    }
}