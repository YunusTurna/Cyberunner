using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{



    public bool onMove;
    Animator anim;
    Rigidbody2D rb;
    public static bool grounded;
   public static SpriteRenderer  sr;
    private int jumpCounter;
    private bool dashBool = true;
    [SerializeField] public static float speed;
    [SerializeField] public static float jumpPower;
    [SerializeField] private float dashPower;
    [SerializeField] private int dashCoolDown;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        speed = 10;
        dashCoolDown = 3;
        jumpPower = 3000;
        dashPower = 200;

        
    }

    // Update is called once per frame
    void Update()
    {
       Movement();
       Jump();
       SpriteFlip();
       StartCoroutine(Dash());



    
    
    }
    void Jump(){
        if(Input.GetKeyDown(KeyCode.Space) & jumpCounter > 0)
        {
            rb.AddForce(Vector2.up * jumpPower);
            jumpCounter -= jumpCounter;
        }
    }

    
    void Movement()
    {
       
        transform.Translate(new Vector3(speed * Input.GetAxisRaw("Horizontal") * Time.deltaTime, 0 , 0));
        
    }
    void SpriteFlip(){
        if(Input.GetAxisRaw("Horizontal") < 0){
            sr.flipX = true;
        }
        else if(Input.GetAxisRaw("Horizontal") > 0){
            sr.flipX = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            jumpCounter = 1;
            
        }
        
        
    }
    IEnumerator Dash()
    {
        if((Input.GetKeyDown(KeyCode.LeftShift) & sr.flipX == true) & (dashBool == true))
        {
            rb.AddForce(Vector2.left * dashPower);
            dashBool = false;
            yield return new WaitForSeconds(dashCoolDown);
            dashBool = true;        
        }
        if((Input.GetKeyDown(KeyCode.LeftShift) & sr.flipX == false) & (dashBool == true))
        {
            rb.AddForce(Vector2.right * dashPower);
            dashBool = false;
            yield return new WaitForSeconds(dashCoolDown);
            dashBool = true;
        }

 
    
    }





}
