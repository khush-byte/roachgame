using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMain : MonoBehaviour
{
    public int level = 0;
    public GameObject level2;    
    public GameObject image1;
    public GameObject image2;
    void Start()
    {        
        if (Global.myLevel == 1)
        {
            level2.SetActive(false);
            image1.SetActive(true);
            level = 1;
        }

        if (Global.myLevel == 2)
        {
            level2.SetActive(true);
            image1.SetActive(false);
            image2.SetActive(true);
            level = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void LevelSelect()
    {
        if (level == 1)
        {            
            SceneManager.LoadScene(2);
            Time.timeScale = 1;            
        }
        if (level == 2)
        {            
            SceneManager.LoadScene(4);
            Time.timeScale = 1;
        }
    }
    public void Switch()
    {
        if (level == 1)
        {
            image1.SetActive(true);
            image2.SetActive(false);
        }
        if (level == 2)
        {
            image1.SetActive(false);
            image2.SetActive(true);
        }
    }
}
