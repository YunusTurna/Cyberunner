using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDead : MonoBehaviour
{
    public static bool dead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
   
    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.tag == "Shrouiken") || (other.gameObject.tag == "PlayerAttack"))
        {
            dead = true;

        }
        else
        {
            dead = false;
        }
    }
}
