using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDown : MonoBehaviour
{
    float speed = 4.0f;
    float direction = -5.0f;
    public GameObject up;

    void Update()
    {
        if (transform.position.y > -0.6f)
        {
            transform.Translate(0, direction * speed * Time.deltaTime, 0);            
        }
        else
        {
            up.SetActive(true);
            gameObject.SetActive(false);            
        }
    }
}
