using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("scene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator scene()
    {

        yield return new WaitForSeconds(27);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
