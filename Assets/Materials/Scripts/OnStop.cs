using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStop : MonoBehaviour
{
    public GameObject line;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject gameLogic;
    
    private void OnMouseDown()
    {
        LineMove GetLine = line.GetComponent<LineMove>();
        GetLine.speed = 1.0f;
        EnemyMove GetEnemy1 = enemy1.GetComponent<EnemyMove>();
        GetEnemy1.speed = 1.0f;
        EnemyMove GetEnemy2 = enemy2.GetComponent<EnemyMove>();
        GetEnemy2.speed = 1.0f;        
    }
    private void OnMouseUp()
    {
        GameLogic GetGame = gameLogic.GetComponent<GameLogic>();
        GetGame.StopOff();
    }   
}
