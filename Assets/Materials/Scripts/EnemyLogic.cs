using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{   
     
    public GameObject player;
    public GameObject clickField;
    public GameObject dead;
    public GameObject boom;
    public GameObject enemyBody;
    public GameObject Enemy1;
    public GameObject Enemy2;    
    public GameObject indic;
    public GameObject theEnd;
    public GameObject snowball;
    public GameObject fly;

    // Start is called before the first frame update
    void Start()
    {
        dead.SetActive(false);
        boom.SetActive(false);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MyScore()
    {
        StartCoroutine(WaitBoom());
        EnemyMove GetEnemy = gameObject.GetComponent<EnemyMove>();
        ClickField GetPlayer = clickField.gameObject.GetComponent<ClickField>();
        IndicMove GetIndic = indic.GetComponent<IndicMove>();
        GetPlayer._score = GetPlayer._score - GetEnemy._life;

        if (GetPlayer._score >= 0)
        {            
            GetIndic.Indec();
            
        }
        else
        {
            StartCoroutine(WaitDead());
        }
    }
    public IEnumerator WaitBoom()
    {        
        boom.SetActive(true);
        yield return new WaitForSeconds(0.07f);
        boom.SetActive(false);
    }

    public IEnumerator WaitDead()
    {
        boom.SetActive(true);
        yield return new WaitForSeconds(0.07f);
        boom.SetActive(false);
        StartCoroutine(WaitBoom());         
        dead.SetActive(true);
        dead.transform.position = new Vector3(player.transform.position.x, enemyBody.transform.position.y - 1.14f, player.transform.position.z);
        enemyBody.SetActive(true);
        GameOver GetTheEnd = theEnd.GetComponent<GameOver>();
        GetTheEnd.TheEnd();
        SnowBallAction GetSnowball = snowball.GetComponent<SnowBallAction>();
        GetSnowball.snowballSpeed = 2.0f;
        fly.SetActive(false);
    }
}
