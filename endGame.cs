using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endGame : MonoBehaviour
{
 
    Text endGame1;
    // Start is called before the first frame update
    void Start()
    {
        endGame1 = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lifeScript.lifeValue <= 0)
        {
            endGame1.text = " " + "GAME OVER!";
           
        }
    }
}
