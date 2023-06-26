using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickField : MonoBehaviour
{
    public float speed = 20.0f;
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
    public GameObject reach;
    float a, b, c, d;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (reach.transform.position.y < -2.6f)
        {
            reach.transform.Translate(0, direction * speed * Time.deltaTime, 0);
        }

        LineMove GetLine = line.GetComponent<LineMove>();
        EnemyMove GetEnemyGroup = EnemyGroup.GetComponent<EnemyMove>();
        EnemyMove GetEnemy2 = enemy2.GetComponent<EnemyMove>();
        if (GetLine.speed > 10)
        {
            //GetLine.speed = GetLine.speed - 40.0f * Time.deltaTime;
            //GetEnemyGroup.speed = GetEnemyGroup.speed - 40.0f * Time.deltaTime;
            //GetEnemy2.speed = GetEnemy2.speed - 40.0f * Time.deltaTime;
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
        GetLine.speed = GetLine.speed + 7.4f * Time.deltaTime;
        EnemyMove GetEnemyGroup = EnemyGroup.GetComponent<EnemyMove>();
        GetEnemyGroup.speed = GetEnemyGroup.speed + 7.4f * Time.deltaTime;
        EnemyMove GetEnemy2 = enemy2.GetComponent<EnemyMove>();
        GetEnemy2.speed = GetEnemy2.speed + 7.4f * Time.deltaTime;
        SnowBallAction GetBall = snowball.GetComponent<SnowBallAction>();
        if (GetBall.transform.position.y > -8.0f)
        {
            GetBall.snowballSpeed = GetBall.snowballSpeed - 7.4f * Time.deltaTime;
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
                flyRoach.transform.position = new Vector3(this.reach.transform.position.x, this.reach.transform.position.y, this.reach.transform.position.z - 0.1f);
                reach.transform.position = new Vector3(left.transform.position.x, reach.transform.position.y, reach.transform.position.z);
                flyRoach.transform.position = new Vector3(this.reach.transform.position.x, this.reach.transform.position.y, this.reach.transform.position.z - 0.1f);
                StartCoroutine(WaitFly());
            }

            if (c < d)
            {
                flyRoach.SetActive(true);
                flyRoach.transform.position = new Vector3(this.reach.transform.position.x, this.reach.transform.position.y, this.reach.transform.position.z - 0.1f);
                reach.transform.position = new Vector3(right.transform.position.x, reach.transform.position.y, reach.transform.position.z);
                flyRoach.transform.position = new Vector3(this.reach.transform.position.x, this.reach.transform.position.y, this.reach.transform.position.z - 0.1f);
                StartCoroutine(WaitFly());
            }
        }
    }

    public IEnumerator Wait()
    {
        Animator anim = reach.GetComponent<Animator>();
        anim.speed = 2.0f;
        reach.transform.localScale = new Vector2(reach.transform.localScale.x + 0.005f, reach.transform.localScale.y + 0.005f);

        if (_score < 99)
        {
            _score = _score + 1;
        }
        yield return new WaitForSeconds(0.1f);
        anim.speed = 0.8f;
        reach.transform.localScale = new Vector2(reach.transform.localScale.x - 0.005f, reach.transform.localScale.y - 0.005f);
    }
    public IEnumerator WaitFly()
    {
        yield return new WaitForSeconds(0.09f);
        flyRoach.SetActive(false);
    }
}
