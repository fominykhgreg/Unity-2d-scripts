
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Uprava : MonoBehaviour
{
    public float horSpeed;
    float speedX;
    public float vertIpmulse;
    Rigidbody2D rb;
    bool isGrounded;
    [SerializeField]
    private float jumpForce = 6.0F;
  
    public GameObject Enemy;
    private Animator animator;
    private SpriteRenderer sprite;
    public GameObject Player;
    private CharState State
    {
        get { return (CharState)animator.GetInteger("State"); }
        set { animator.SetInteger("State", (int)value);  }
    }


  


    private void Awake()
    {
        
     
        animator = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();

       
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
      
            Player = GameObject.FindWithTag("Player");
       

    }

    

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isGrounded) { State = CharState.idle; }

        



        if (Input.GetKey(KeyCode.LeftArrow))
        { speedX = -horSpeed;
            State = CharState.run;
            if (speedX < 0)
            {
                rb.transform.rotation = Quaternion.Euler(0, 0, 0);
                
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            speedX = -horSpeed;
            State = CharState.run;
            if (speedX < 0)
            {
                rb.transform.rotation = Quaternion.Euler(0, 180, 0);
               
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            State = CharState.jump1;
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
        transform.Translate(speedX, 0, 0);
        speedX = 0;

       

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Ground")
            isGrounded = true;
        rb.velocity = Vector3.zero;
        rb.AddForce(transform.up * 6.0F, ForceMode2D.Impulse);
        if (collision.gameObject.tag == "Enemy")
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(transform.up * 6.0F, ForceMode2D.Impulse);
            lifeScript.lifeValue -= 1;
            
            State = CharState.hit;
       
         
            

            
        }
        if (lifeScript.lifeValue <= 0)
        {
            State = CharState.smert;
            Destroy(Player);
            FindObjectOfType<gameManager>().gameOver();
        }
    }

   
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            isGrounded = false;
        
    }
   
}
public enum CharState
{
    idle,
    run,
    jump1,
    hit,
    smert
}
