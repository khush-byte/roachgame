using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public float speed = 1.0f;
    public float direction = 1.0f;
    public GameObject line;
    public GameObject EnemyGroup;
    public GameObject enemy2;
    public TextMesh scoreLabel;
    public int _score = 0;
    public GameObject left;
    public GameObject right;
    public GameObject flyRoach;
    public GameObject snowball;
    float a, b, c, d;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2.6f)
        {
            transform.Translate(0, direction * speed * Time.deltaTime, 0);
        }

        LineMove GetLine = line.GetComponent<LineMove>();
        EnemyMove GetEnemyGroup = EnemyGroup.GetComponent<EnemyMove>();
        EnemyMove GetEnemy2 = enemy2.GetComponent<EnemyMove>();
        if (GetLine.speed > 2)
        {
            GetLine.speed = GetLine.speed - 0.075f;
            GetEnemyGroup.speed = GetEnemyGroup.speed - 0.075f;
            GetEnemy2.speed = GetEnemy2.speed - 0.075f;
        }

        scoreLabel.text = _score + "";
        if (_score < 0)
        {
            scoreLabel.text = "0";
        }
    }
    private void OnMouseDown()
    {
        StartCoroutine(Wait());
        LineMove GetLine = line.GetComponent<LineMove>();
        GetLine.speed = GetLine.speed + 0.76f;
        EnemyMove GetEnemyGroup = EnemyGroup.GetComponent<EnemyMove>();
        GetEnemyGroup.speed = GetEnemyGroup.speed + 0.76f;
        EnemyMove GetEnemy2 = enemy2.GetComponent<EnemyMove>();
        GetEnemy2.speed = GetEnemy2.speed + 0.76f;
        SnowBallAction GetBall = snowball.GetComponent<SnowBallAction>();
        if (GetBall.transform.position.y > -8.0f)
        {
            GetBall.snowballSpeed = GetBall.snowballSpeed - 0.16f;
        }        

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                a = touch.position.x - 12.0f;
                c = touch.position.x;
            }
        }
    }
    private void OnMouseUp()
    {
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Ended)
        {
            b = touch.position.x;
            d = touch.position.x - 12.0f;

            if (a > b)
            {
                flyRoach.SetActive(true);
                flyRoach.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z - 0.1f);
                transform.position = new Vector3(left.transform.position.x, transform.position.y, transform.position.z);
                flyRoach.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z - 0.1f);
                StartCoroutine(WaitFly());
            }

            if (c < d)
            {
                flyRoach.SetActive(true);
                flyRoach.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z - 0.1f);
                transform.position = new Vector3(right.transform.position.x, transform.position.y, transform.position.z);
                flyRoach.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z - 0.1f);
                StartCoroutine(WaitFly());
            }
        }
    }

    public IEnumerator Wait()
    {
        Animator anim = gameObject.GetComponent<Animator>();
        anim.speed = 2.0f;
        gameObject.transform.localScale = new Vector2(gameObject.transform.localScale.x + 0.005f, gameObject.transform.localScale.y + 0.005f);

        if (_score < 99)
        {
            _score = _score + 1;
        }
        yield return new WaitForSeconds(0.1f);
        anim.speed = 0.8f;
        gameObject.transform.localScale = new Vector2(gameObject.transform.localScale.x - 0.005f, gameObject.transform.localScale.y - 0.005f);
    }
    public IEnumerator WaitFly()
    {
        yield return new WaitForSeconds(0.09f);
        flyRoach.SetActive(false);
    }   
}
