using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketEnterence : MonoBehaviour
{
    [SerializeField] GameObject world;
    [SerializeField] GameObject market;
    private bool entermarket;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(entermarket == true & Input.GetKey(KeyCode.E)){
            
            
                world.SetActive(false);
                market.SetActive(true);
                Cursor.visible  =true;            
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
           entermarket = true;
           Debug.Log("Çalıştı");
        }
        else
        {
            entermarket = false;
        }
    }
}
