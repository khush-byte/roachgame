using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoUp : MonoBehaviour
{
    float speed = 4.0f;
    float direction = -5.0f;
    public GameObject down;

    void Update()
    {
        if (transform.position.y < 4.31f)
        {
            transform.Translate(0, direction * speed * Time.deltaTime, 0);
        }
        else
        {
            down.SetActive(true);
            gameObject.SetActive(false);            
        }
    }
}
