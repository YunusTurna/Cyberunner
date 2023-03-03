
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject fireBall;
    [SerializeField] GameObject wizard;
    
    public static bool attack = false;
    public static bool isLeft = false;
    public static bool isRight = false;
    
    
    

    void Start()
    {
        InvokeRepeating("Attack" , 0 , 2);
    }
    void Update()
    {
        
        
      
       
      
      
    }
    void Attack()
    {
        if(attack == true)
        {
        Instantiate(fireBall , transform.position , Quaternion.Euler(0,0,0));
        }

    }
   
}
