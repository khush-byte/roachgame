using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{    
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject menu;   
    public GameObject line;
    public GameObject player;
    public GameObject timeCount;
    public GameObject lose;
    public GameObject pause;
    public GameObject stop;    
    public GameObject movement;
    public GameObject gameLogic;
    public GameObject fly;
    
    // Start is called before the first frame update
    void Start()
    {
        lose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TheEnd()
    {
        TimeCount GetTime = timeCount.GetComponent<TimeCount>();
        GetTime.enabled = false;
        LineMove GetLine = line.GetComponent<LineMove>();
        GetLine.enabled = false;
        player.gameObject.SetActive(false);        
        EnemyMove GetEnemy1 = Enemy1.GetComponent<EnemyMove>();
        GetEnemy1.enabled = false;
        EnemyMove GetEnemy2 = Enemy2.GetComponent<EnemyMove>();
        GetEnemy2.enabled = false;
        menu.SetActive(true);
        lose.SetActive(true);
        pause.SetActive(false);               
        movement.SetActive(false);
        GameLogic GetOver = gameLogic.GetComponent<GameLogic>();
        GetOver.alive = false;
        stop.SetActive(false);
        Destroy(fly);
    }   
}
