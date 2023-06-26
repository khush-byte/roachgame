using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMove : MonoBehaviour
{
    public float speed = 3.0f;
    private float direction = -1.0f;   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (speed > 3)
        {
            speed -= 0.7f * Time.deltaTime;
        }
        transform.Translate(0, direction * speed * Time.deltaTime, 0);
        if (transform.position.y < -9.0f)
        {
            transform.Translate(0, 22, 0);
            
        }       
    }
}
