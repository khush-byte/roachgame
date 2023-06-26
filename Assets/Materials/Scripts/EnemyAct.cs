using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAct : MonoBehaviour
{    
    public GameObject enemy;
    public GameObject body;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            EnemyLogic GetEnemy = enemy.gameObject.GetComponent<EnemyLogic>();           
            GetEnemy.MyScore();
            body.SetActive(false);
        }
        if (collider.gameObject.tag == "Bullet")
        {
            body.SetActive(false);
        }
    }    
}
