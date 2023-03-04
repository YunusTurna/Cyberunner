using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Camera))]
public class Shuriken_Script : MonoBehaviour
{
    public Transform Crosshair;
    private Camera cameraa;
    public GameObject player;
    public GameObject bulletPrefab;
    public GameObject bulletStart;
    public float bulletSpeed = 60.0f;

    private Vector3 target;
    private Vector3 difference;
    private Vector3 distance;

    private float rotationZ;
    private bool throwBool = false;

    // Use this for initialization
    void Start()
    {
        cameraa = GetComponent<Camera>();
        Cursor.visible = false;
        InvokeRepeating("Throw" , 0 , 2);
    }

    // Update is called once per frame
    void Update()
    {



        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        Crosshair.transform.position = new Vector2(target.x, target.y);
        
        Vector3 difference = target - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

        if (Input.GetMouseButtonDown(1))
        {
            if(throwBool == true)
            {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            fireBullet(direction, rotationZ);
            throwBool = false;
            }
        }
    }
    void fireBullet(Vector2 direction, float rotationZ)
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = bulletStart.transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }

    void Throw()
    {
        throwBool = true;
        

    }
}
