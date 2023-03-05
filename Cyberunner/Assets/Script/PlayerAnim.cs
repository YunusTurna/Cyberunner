using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    private bool grounded = false;
    void Start()
    {
      anim = GetComponent<Animator>();
      rb = GetComponent<Rigidbody2D>();      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            grounded = false;
        }
        if(Input.GetAxisRaw("Horizontal") != 0){
            anim.SetBool("Run" , true);
        }
        else{
            anim.SetBool("Run" , false);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetBool("Attack", true);
        }
        else
        {
            anim.SetBool("Attack", false);

        }
        Jump();

    }
    void Jump()
    {
        if(rb.velocity.y > 0 & grounded == false){
            anim.SetInteger("JumpOrFall" , 1);
        }
        else if(rb.velocity.y < 0 & grounded == false)
        {
            anim.SetInteger("JumpOrFall" , -1);
        }
        if(grounded == true)
        {
            anim.SetInteger("JumpOrFall" , 0);

        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            grounded = true;

        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Fireball")
        {
            anim.SetBool("Dead" , true);
        }
    }
}
