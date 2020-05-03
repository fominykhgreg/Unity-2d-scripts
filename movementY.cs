using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementY : MonoBehaviour
{

    public int Speed = 1;
    public Transform point_1;
    public Transform point_2;
    Rigidbody2D rgb;
    bool OnRight;
    public bool FaceRight = true;

    void Awake()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if ((gameObject.transform.position.y <= point_1.position.y) && (FaceRight))
        {
            OnRight = true;
            Flip();
        }
        if ((gameObject.transform.position.y >= point_2.position.y) && (!FaceRight))
        {
            OnRight = false;
            Flip();
        }

        MakePosition();
    }

    void MakePosition()
    {
        if (OnRight)
        {
            rgb.velocity = new Vector3(Speed, rgb.velocity.x);

        }
        else
        {
            rgb.velocity = new Vector3(-Speed, rgb.velocity.x);
        }
    }

    void Flip()
    {
        FaceRight = !FaceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

}