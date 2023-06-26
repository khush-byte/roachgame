using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMove : MonoBehaviour
{
    public float speed = 5.0f;
    private float direction = -1.0f;
    public TextMesh enemyLife;
    public int _life = 3;
    public GameObject enemy;
    public GameLogic game;
    int level;

    // Start is called before the first frame update
    void Start()
    {
        enemyLife.text = _life + "";
        GameLogic GetGame = game.GetComponent<GameLogic>();
        level = GetGame.difficulty;
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
            
            enemy.SetActive(true);
            transform.Translate(0, 22, 0);
            _life = UnityEngine.Random.Range(level, level+12);
            enemyLife.text = _life + "";
        }
    }
}
