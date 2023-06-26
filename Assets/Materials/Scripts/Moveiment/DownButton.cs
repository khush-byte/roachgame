using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownButton : MonoBehaviour
{
    public GameObject downGo;
    public GameObject up;
    public GameObject upGo;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    void Start()
    {        
        downGo.SetActive(false);
        up.SetActive(false);
        upGo.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
    }
    private void OnMouseDown()
    {      
        downGo.SetActive(true);
        downGo.transform.position = this.gameObject.transform.position;
        gameObject.SetActive(false);            
    }
}
