using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    Animator anim;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    void Start()
    {
        if (Input.GetMouseButtonDown(0))

        {
            Attack();



        }

        // Update is called once per frame

        void Attack()
        {
            



            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

            foreach (Collider2D enemy in hitEnemies)
            {

                Debug.Log(("We hit") + enemy.name);

            }

        }



        void OndrawGizmosSelected()
        {

            if (attackPoint == null)
                return;


            Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        }
    }
}
