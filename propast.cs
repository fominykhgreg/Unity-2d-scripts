using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Represebts the current vital statistics of some game entity.
    /// </summary>
    public class propast : MonoBehaviour
    {

        public GameObject Trig;


        void Start()
        {
            Trig = GameObject.FindWithTag("Player");
        }


        void Update()
        {
            float direction1 = Trig.transform.position.y - transform.position.y;

            if (direction1 <= 0)
            {
                Destroy(Trig);
                lifeScript.lifeValue -= 100;


            }


        }
    }
}
