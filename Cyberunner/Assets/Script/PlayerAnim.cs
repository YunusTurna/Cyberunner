using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    Animator anim;
    void Start()
    {
      anim = GetComponent<Animator>();      
    }

    // Update is called once per frame
    void Update()
    {
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

    }
}
