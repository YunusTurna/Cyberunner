using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrouikenDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject , 0.3f);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            Debug.Log("Çarptı");
            
        }

        if (other.gameObject.tag == "Fireball")
        {
            Destroy(gameObject);

        }

    }
}
