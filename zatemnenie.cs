using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class zatemnenie : MonoBehaviour
{

    
    public Image AlphaImage;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (winScript.winValue == 1)
        {
      
            AlphaImage.color = new Color(AlphaImage.color.r, AlphaImage.color.g, AlphaImage.color.b, AlphaImage.color.a + 0.5f * Time.deltaTime);
        }
    } 
}
