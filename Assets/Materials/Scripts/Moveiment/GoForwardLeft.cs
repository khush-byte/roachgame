using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoForwardLeft : MonoBehaviour
{
    float dir = -1.0f;
    float speed = 12.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -3.5f)
        {
            transform.Translate(dir * speed * Time.deltaTime, 0, 0);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
