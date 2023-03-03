using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    private Vector2 target;
    public float speed;

    void Start()
    {
        
        speed = 20;
    }
    void Update()
    {
        target =Camera.main.ScreenToViewportPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, target ,speed);
        Destroy(gameObject, 5f);
    }


  

}
