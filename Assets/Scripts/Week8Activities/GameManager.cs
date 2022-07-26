using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private Character playerOne;
        [SerializeField] private Character playerTwo;

       // [SerializeField] private Character[] players;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
               // for (int i = 0; i < players.Length; i++)
               // {
               //    if (players[i] != null)
               //   {

               //   }
                
                if(playerOne != null)
                {
                    // the adjustment
                    playerOne.morale -= Random.Range(1, 13);
                    playerOne.health -= Random.Range(1, 9);

                    if (playerOne.health <= 0)
                    {
                        Destroy(playerOne.gameObject);
                    }
                }
                if (playerTwo != null)
                {
                    playerTwo.morale -= Random.Range(1, 13);
                    playerTwo.health -= Random.Range(1, 9);

                    if (playerTwo.health <= 0)
                    {
                        Destroy(playerTwo.gameObject);
                        playerTwo = null;
                    }
                }
            }
        }
    }
}



