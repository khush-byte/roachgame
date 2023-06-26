using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicMove : MonoBehaviour
{
    public float _scale = 0.026f;
    public float _position = 0.12f;
    public GameObject indicFon;
    public GameObject menu;
    public GameObject menu2;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject line;
    public GameObject player;
    public TextMesh blocks;
    private int _block = 0;
    public GameObject win;
    public GameObject timeCount;
    public GameObject pause;
    public GameObject clickField;
    public GameObject movement;
    public GameObject forward;
    public GameObject fly;
    public GameObject snowball;
    public GameObject pausedRoach;
    public GameObject gameLogic;
    public GameObject stop;
    bool isWin = false;

    // Start is called before the first frame update
    void Start()
    {
        indicFon.SetActive(false);
        win.SetActive(false);
        menu2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isWin==true)
        {
            ClickField GetPlayer = clickField.GetComponent<ClickField>();
            GetPlayer.enabled = false;
            if (player.transform.position.y < 9.0f)
            {
                player.transform.Translate(0, 2.0f * Time.deltaTime, 0);
            }
        }
    }

    public void Indec()
    {
        transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y + _scale);
        transform.position = new Vector3(transform.position.x, transform.position.y + _position, transform.position.z);
        _block = _block + 1;
        blocks.text = _block + "";
        if (transform.localScale.y > 0.4f)
        {
            indicFon.SetActive(true);
            Win();
        }
    }
    private void Win()
    {
        TimeCount GetTime = timeCount.GetComponent<TimeCount>();
        GetTime.enabled = false;
        EnemyMove GetEnemy1 = Enemy1.GetComponent<EnemyMove>();
        GetEnemy1.enabled = false;
        EnemyMove GetEnemy2 = Enemy2.GetComponent<EnemyMove>();
        GetEnemy2.enabled = false;
        LineMove GetLine = line.GetComponent<LineMove>();
        GetLine.enabled = false;        
        win.SetActive(true);
        menu.SetActive(true);
        pause.SetActive(false);
        movement.SetActive(false);
        menu2.SetActive(true);
        SpriteRenderer color = forward.GetComponent<SpriteRenderer>();
        color.color = Color.clear;
        fly.SetActive(false);
        snowball.SetActive(false);        
        isWin = true;
        GameLogic GetOver = gameLogic.GetComponent<GameLogic>();
        GetOver.alive = false;
        stop.SetActive(false);
        Global.myLevel = 2;
    }
}
