using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPause : MonoBehaviour
{
    public bool pausedOn;
    public GameObject menu;
    public GameObject move1;
    public GameObject move2;
    public GameObject player;
    public GameObject pausedRoach;
    public GameObject snowball;

    private void Start()
    {
        pausedRoach.SetActive(false);
        menu.SetActive(false);
    }
    private void OnMouseDown()
    {
        
        if (!pausedOn)
        {
            pausedOn = true;
            menu.SetActive(true);
            Time.timeScale = 0;
            move1.SetActive(false);
            move2.SetActive(false);
            player.SetActive(false);
            pausedRoach.SetActive(true);
            pausedRoach.transform.position = player.transform.position;
            SpriteRenderer color = gameObject.GetComponent<SpriteRenderer>();
            color.color = Color.cyan;
            SnowBall GetSnowball = snowball.GetComponent<SnowBall>();
            GetSnowball.enabled = false;
        }
        else
        {
            pausedOn = false;
            menu.SetActive(false);
            Time.timeScale = 1;
            move1.SetActive(true);
            move2.SetActive(true);
            player.SetActive(true);
            pausedRoach.SetActive(false);
            SpriteRenderer color = gameObject.GetComponent<SpriteRenderer>();
            color.color = Color.white;
            SnowBall GetSnowball = snowball.GetComponent<SnowBall>();
            GetSnowball.enabled = true;
        }
    }   
}


