using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{
    public class DamagingObject : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.GetComponent<Health>() != null)
            collision.gameObject.GetComponent<Health>().health -= 10;
            // check for <0 health and destroy them

            if(collision.gameObject.GetComponent<Health>().health <= 0)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}

