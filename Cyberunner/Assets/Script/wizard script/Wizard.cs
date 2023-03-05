
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{

    Animator anim;
    public GameObject player;
    [SerializeField] GameObject fireBall;
    [SerializeField] GameObject wizard;
    [SerializeField] GameObject coin;
    public static bool attack = false;
    public static bool isLeft = false;
    public static bool isRight = false;
    public bool flip;
    public float speed;
    public static bool dead;

    private Transform playerPos;
    private Vector2 currenPos;
    public float distance;
    public float speedEnemy;


    void Start()
    {
        anim = GetComponent<Animator>();
        InvokeRepeating("Attack", 0, 2);
        InvokeRepeating("AttackTrue" , 0 , 2);
        playerPos = player.GetComponent<Transform>();
        currenPos = GetComponent<Transform>().position;
        distance = 5;

    }




    private void Update()
    {

        if (Mathf.Abs(player.transform.position.x - transform.position.x) < 5  & Mathf.Abs(player.transform.position.y - transform.position.y) < 5)
        {
            if(attack == true)
            {
                Attack();

            }
            
            attack = false;
        }
        else
        {
            if (Vector2.Distance(transform.position, currenPos) <= 0)
            {
                
            }
            else
            {
                attack = false;
            }
        }








        Vector3 scale = transform.localScale;
        if (player.transform.position.x > transform.position.x)
        {
            scale.x = Mathf.Abs(scale.x) * -1 * (flip ? -1 : 1);
            transform.Translate(x: speed * Time.deltaTime, y: 0, z: 0);

        }
        else
        {

            scale.x = Mathf.Abs(scale.x) * (flip ? -1 : 1);
            transform.Translate(x: speed * Time.deltaTime * -1, y: 0, z: 0);
        }
        transform.localScale = scale;
       
    }




    void Attack()
    {
        if (attack == true)
        {
            anim.SetBool("IsAttack", true);
            Instantiate(fireBall, transform.position, Quaternion.Euler(0, 0, 0));
            attack = false;
            
        }
        else
        {
            anim.SetBool("IsAttack", false);
        }
    }
    void AttackTrue(){
        attack = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.tag == "Shrouiken"))
        {
            Destroy(wizard);
            Instantiate(coin, transform.position, Quaternion.Euler(0, 0, 0));

        }
      
    }
}