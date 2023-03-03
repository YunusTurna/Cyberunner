using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shurikendeneme : MonoBehaviour
{
    public Camera m_camera;

    public Transform gun_holder;
    public Transform fire_point;
    public GameObject shuriken;




    private void Update()
    {
        RotateGun();
        PlayerInput();
    }



    void RotateGun()
    {
        Vector2 distanceVector = (Vector2)m_camera.ScreenToWorldPoint(Input.mousePosition) - (Vector2)gun_holder.position;
        float angle = Mathf.Atan2(distanceVector.y, distanceVector.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }

    // Update is called once per frame
    void PlayerInput()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Instantiate(shuriken, fire_point.position, transform.rotation);
        }
    }
}
