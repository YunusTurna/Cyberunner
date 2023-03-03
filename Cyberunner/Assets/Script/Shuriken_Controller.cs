using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken_Controller : MonoBehaviour
{
    public bool canThrowShurien;
    public PlayerMovement player;
    public int shskilltime;
    public GameObject shuriken;
    public AudioSource bulletVoice;
    public static Vector2 mousePos;
    public float offSet;

    void Start()
    {
        canThrowShurien = true;
        shskilltime = 6;
    }

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x,Input.mousePosition.y));


       
            

        if (canThrowShurien == true)
        {
  if (Input.GetMouseButtonDown(1))
        {
            shot();
           
        }
        }

       transform.position = player.transform.position;

    }

    void FixedUpdate()
    {
        float rotateZ = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offSet);
    }

    private void shot()
    {
        Instantiate(shuriken, transform.position, Quaternion.identity);
        StartCoroutine("shurikenwait");
        canThrowShurien = false;
    }


    IEnumerator shurikenwait()
        {

        yield return new WaitForSeconds(shskilltime);
        canThrowShurien = true;
        StopCoroutine("shurikenwait");

    }



}