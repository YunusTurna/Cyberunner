using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    private Transform player;
    private Vector2 target;
    public float speed;
    Rigidbody2D rb;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);

        rb = GetComponent<Rigidbody2D>();
        speed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DestroyProjectile();
        }

        if (other.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }

        void DestroyProjectile()
        {
            Destroy(gameObject , 3f);
        }

   
    
    
    }
}