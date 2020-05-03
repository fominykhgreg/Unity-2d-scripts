using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
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
        if ((gameObject.transform.position.x <= point_1.position.x) && (FaceRight))
        {
            OnRight = true;
            Flip();
        }
        if ((gameObject.transform.position.x >= point_2.position.x) && (!FaceRight))
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
            rgb.velocity = new Vector2(Speed, rgb.velocity.y);

        }
        else
        {
            rgb.velocity = new Vector2(-Speed, rgb.velocity.y);
        }
    }

    void Flip()
    {
        FaceRight = !FaceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

}