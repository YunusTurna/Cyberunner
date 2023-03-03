using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    private Vector2 target;
    public float speed;

    void Start()
    {
        
        speed = 300;
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,Shuriken_Controller.mousePos,speed);
        Destroy(gameObject, 5f);
    }


  

}
