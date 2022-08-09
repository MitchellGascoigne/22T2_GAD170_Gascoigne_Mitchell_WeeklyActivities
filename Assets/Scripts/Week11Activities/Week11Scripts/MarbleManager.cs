using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{
    public class MarbleManager : MonoBehaviour
    {
        // Spawn a marble every few seconds
        // Need to use "Instantiate" method

        

        [SerializeField] private GameObject marbleSpawnPoint;
        [SerializeField] private GameObject marblePrefab;
        [SerializeField] private float timer;
        [SerializeField] private float timerReset = 2;

        [SerializeField] private Vector3 averageMarblePosition;

        public List<GameObject> allMarbles = new List<GameObject>();

        private void Start()
        {
            timer = timerReset;
        }

        // Update is called once per frame
        void Update()
        {
            timer -= Time.deltaTime;

            if (timer < 0)
            {
                timer = timerReset;
                GameObject newMarble = Instantiate(marblePrefab, marbleSpawnPoint.transform.position, Quaternion.identity);

                newMarble.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, -100));
                // Add our new marble to the list of marbles
                allMarbles.Add(newMarble);
            }
            UpdateCameraLook();
        }
        private void UpdateCameraLook()
        {
            if (allMarbles.Count > 0)
            {
                for (int i = 0; i < allMarbles.Count; i++)
                {
                    averageMarblePosition += allMarbles[i].transform.position;
                }

                averageMarblePosition /= allMarbles.Count;

                Camera.main.transform.LookAt(averageMarblePosition);
            }

        }

    }

}
