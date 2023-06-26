using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour
{
    public float speed = 1.0f;
    private float direction = 1.0f;
    public GameObject dead;
    public GameObject player;
    public GameObject theEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, direction * speed, 0);
    }
    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Player")
        {         
            dead.SetActive(true);
            dead.transform.position = player.transform.position;            
            GameOver GetTheEnd = theEnd.GetComponent<GameOver>();
            GetTheEnd.TheEnd();
        }
    }
}
