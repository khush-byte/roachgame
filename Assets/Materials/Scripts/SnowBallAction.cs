using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallAction : MonoBehaviour
{
    private float direction = 1.0f;
    public float snowballSpeed = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        snowballSpeed = snowballSpeed + 0.14f * Time.deltaTime;
        if (transform.position.y > -6.0f)
        {
            transform.Translate(0, direction * snowballSpeed * Time.deltaTime, 0);
        }
        else
        {
            snowballSpeed = 20.0f * Time.deltaTime;
            transform.Translate(0, direction * snowballSpeed * Time.deltaTime, 0);
        }
    }
}
