using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip najim;

    public void Sound()
    {
        myFx.PlayOneShot(najim);
    }
    // Start is called before the first frame update
   
}
