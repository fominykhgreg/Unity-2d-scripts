using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Represebts the current vital statistics of some game entity.
    /// </summary>
    public class chudishe : MonoBehaviour
    {

        public GameObject Player;


        void Start()
        {
            Player = GameObject.FindWithTag("Player");
        }


        void Update()
        {
            float direction = Player.transform.position.x - transform.position.x;

            if (direction < 3)
            {
                Destroy(Player);
                FindObjectOfType<gameManager>().gameOver();
                lifeScript.lifeValue -= 100;
            }


        }
    }
}
