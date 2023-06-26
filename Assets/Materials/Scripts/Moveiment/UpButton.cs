using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpButton : MonoBehaviour
{
    public GameObject upGo;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    private void OnBecameVisible()
    {
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
    } 

    private void OnMouseDown()
    {
        upGo.SetActive(true);
        upGo.transform.position = this.gameObject.transform.position;
        gameObject.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
    }
}
