using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardDead : MonoBehaviour
{
    
    public static bool dead;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Shrouiken")
        {
             dead = true;

        }
        else{
            dead = false;
        }
    }
}
