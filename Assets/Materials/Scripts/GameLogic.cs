using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameLogic : MonoBehaviour
{
    public int difficulty = 3;
    public GameObject menu1;
    public GameObject menu2;
    public GameObject stop;
    public GameObject stopAnim;
    public GameObject snowball;
    public bool alive = true;

    private void Start()
    {
        menu1.SetActive(false);
        menu2.SetActive(false);
        stopAnim.SetActive(false);
    }
    private void Update()
    {
        if (snowball.activeSelf)
            {
            if (snowball.transform.position.y > 9.0f)
            {
                snowball.SetActive(false);
            }
        }
    }
    public void StopOff()
    {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        stop.SetActive(false);
        stopAnim.SetActive(true);
        yield return new WaitForSeconds(19.9f);
        stopAnim.SetActive(false);
        if (alive)
        {
            stop.SetActive(true);
        }
    }
}
