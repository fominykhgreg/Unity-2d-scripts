using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{

    public GameObject Player;






    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }


    void OnCollisionEnter2D(Collision2D variable)
    {
        if (variable.gameObject == Player)
        {
            lifeScript.lifeValue += 1;
            Destroy(gameObject);

        }

    }
}

