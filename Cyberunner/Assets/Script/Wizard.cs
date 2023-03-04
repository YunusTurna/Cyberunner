
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{

    Animator anim;
    [SerializeField] GameObject player;
    [SerializeField] GameObject fireBall;
    [SerializeField] GameObject wizard;
    
    public static bool attack = false;
    public static bool isLeft = false;
    public static bool isRight = false;
    
    
    

    void Start()
    {
        anim = GetComponent<Animator>();
        InvokeRepeating("Attack" , 0 , 2);
   
    
    }
   



        private void Update()
        {
            Vector3 scale = transform.localScale;
            if (player.transform.position.x > transform.position.x)
        {
            scale.x = Mathf.Abs(scale.x) * -1;
        
        
        }
         else
        {

            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;
}



    
    void Attack()
    {
        if(attack == true)
        {
            anim.SetBool("IsAttack", true);
            Instantiate(fireBall , transform.position , Quaternion.Euler(0,0,0));
 }
        else
        {
            anim.SetBool("IsAttack", false);
        }
    }
   
}
