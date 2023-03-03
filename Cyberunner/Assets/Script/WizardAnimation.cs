using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardAnimation : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Wizard.attack == true){
            anim.SetBool("IsAttack" , true);
        }
        else{
            anim.SetBool("IsAttack" , false);
        }
    }
}