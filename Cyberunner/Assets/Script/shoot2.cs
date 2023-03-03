using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot2 : MonoBehaviour
{

    public float bullet_speed = 4;
    public float bullet_duration = 4;

    Rigidbody2D bullet_rigidbody;

    private void Awake()
    {
        bullet_rigidbody = GetComponent<Rigidbody2D>();

    }
    void Start()
    {
        Invoke("DestroyBullet", bullet_duration);
    }

    // Update is called once per frame
   private void FixedUpdate()
    {
        bullet_rigidbody.MovePosition(transform.position + transform.right * bullet_speed * Time.deltaTime);
    }



    void DestroyBullet()
    {
        Destroy(gameObject);
    }


}
