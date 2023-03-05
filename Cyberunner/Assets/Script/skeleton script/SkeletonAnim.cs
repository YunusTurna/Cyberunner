using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAnim : MonoBehaviour
{
    Animator anime;
    public Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (enemy.animok == true)
        {
            anime.SetBool("MoveSke", true);
        }
        else
        {
            anime.SetBool("MoveSke", false);
        }


    }
}
