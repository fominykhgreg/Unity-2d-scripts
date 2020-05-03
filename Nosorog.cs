using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;






namespace Platformer.Mechanics2
{
    /// <summary>
    /// Represebts the current vital statistics of some game entity.
    /// </summary>
    public class Nosorog : MonoBehaviour
    {

        public GameObject Enemy1;

       




        void Start()
        {
            Enemy1 = GameObject.FindWithTag("Player");
        }


        void OnCollisionEnter2D(Collision2D variable)
        {
            if (Mathf.Abs(Enemy1.transform.position.y - transform.position.y) <0.5 && variable.gameObject == Enemy1)
            {
                lifeScript.lifeValue -= 1;
            
                
            }

        }
    }
}

