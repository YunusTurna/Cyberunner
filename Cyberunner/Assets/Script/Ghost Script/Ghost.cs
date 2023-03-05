using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{

    Animator anime;
    public GameObject player;
    [SerializeField] GameObject coin;
    [SerializeField] Transform target;
    public bool flip;
    public float speed;

    private Transform playerPos;
    private Vector2 currenPos;
    public float distance;
    public float speedEnemy;
    public bool animok;

    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
        playerPos = player.GetComponent<Transform>();
        currenPos = GetComponent<Transform>().position;
        animok = true;
    }

    // Update is called once per frame


    private void Update()
    {

        if (Vector2.Distance(transform.position, playerPos.position) < distance)
        {

            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speedEnemy * Time.deltaTime);
            animok = true;
        }
        else
        {
            if (Vector2.Distance(transform.position, currenPos) <= 0)
            {

            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, currenPos, speedEnemy * Time.deltaTime);
                animok = false;
            }
        }

        if (animok == true)
        {
            anime.SetBool("MoveSke", true);
        }
        else
        {
            anime.SetBool("MoveSke", false);
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



        if (EnemyDead.dead == true)
        {
            Destroy(gameObject);
            Instantiate(coin, transform.position, Quaternion.Euler(0, 0, 0));

        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.tag == "Shrouiken") || (other.gameObject.tag == "PlayerAttack"))
        {
            Destroy(gameObject);
            Instantiate(coin, transform.position, Quaternion.Euler(0, 0, 0));

        }

    }
}
