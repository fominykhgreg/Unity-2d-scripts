using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winScript : MonoBehaviour
{
    public static int winValue = 0;
    Text winGame1;
    // Start is called before the first frame update
    void Start()
    {
        winGame1 = GetComponent<Text>();
    }

   
    // Update is called once per frame
    void Update()
    {
        if (winValue == 1)
        {
            //Application.LoadLevel("gameover");
            //winGame1.text = " " + "CONGRATULATIONS! YOU WON!";
            FindObjectOfType<gameManager>().gameWin();
        }
    }
}
