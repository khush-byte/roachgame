using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Roach : MonoBehaviour
{
    public GameObject roach;
    public GameObject roach2;
    public GameObject food;
    public GameObject wall;
    public GameObject snowball;
    public GameObject snowballRotate;
    bool go = true;
    public GameObject play;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer color = gameObject.GetComponent<SpriteRenderer>();
        color.color = Color.clear;
        roach2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (go == true)
        {
            if (transform.position.y > 0.32f)
            {
                transform.Translate(0, 2 * Time.deltaTime, 0);
            }
            else
            {
                SpriteRenderer color = gameObject.GetComponent<SpriteRenderer>();
                color.color = Color.white;
                roach.SetActive(false);
                StartCoroutine(Wait());
            }
        }
        else
        {
            StartCoroutine(Wait());
        }
    }
    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.0f);
        food.SetActive(false);
        yield return new WaitForSeconds(1.0f);
        wall.SetActive(false);
        SnowBall GetSnowball = snowballRotate.GetComponent<SnowBall>();
        GetSnowball.speed = 3.0f;
        if (snowball.transform.position.y < 8.0f)
        {
            snowball.transform.Translate(0, 0.48f * Time.deltaTime, 0);
        }
        yield return new WaitForSeconds(0.6f);
        SpriteRenderer color = gameObject.GetComponent<SpriteRenderer>();
        color.color = Color.clear;
        roach2.SetActive(true);
        if (transform.position.y < 9.0f)
        {
            go = false;
            transform.Translate(0, -0.72f * Time.deltaTime, 0);
            yield return new WaitForSeconds(0.5f);
            if (play.transform.localScale.x > 0.71f)
            {
                play.transform.localScale = new Vector3(play.transform.localScale.x - 0.003f, play.transform.localScale.y - 0.003f, 1);
               
            }
            if (play.transform.position.y > -2.4f)
            {
                play.transform.Translate(0, -1.2f * Time.deltaTime, 0);
            }
            else
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}
