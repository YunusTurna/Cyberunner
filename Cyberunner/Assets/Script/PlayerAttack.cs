using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject playerAttackLeft;
    
    void Start()
    {
        playerAttackLeft.SetActive(false);
       
    }


    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Mouse0) & PlayerMovement.sr == true)
        {
            StartCoroutine(AttackLeft());
        }
        
    }
    IEnumerator AttackLeft()
    {
     playerAttackLeft.SetActive(true);
     yield return new WaitForSeconds(1);
     playerAttackLeft.SetActive(false);   

    }
    
}
