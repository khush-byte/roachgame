using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCount : MonoBehaviour
{
    public TextMesh TheTime;
    public GameObject theEnd;
    public GameObject snowball;
    public GameObject image;
    public float timeLeft = 30.0f;
    int myTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        int myTime = Mathf.RoundToInt(timeLeft);
        TheTime.text = myTime + "";        
        if (timeLeft < 0)
        {            
            image.SetActive(false);
            SnowBallAction GetSnowball = snowball.GetComponent<SnowBallAction>();
            GetSnowball.snowballSpeed = 10.0f;
        }
    }
}
