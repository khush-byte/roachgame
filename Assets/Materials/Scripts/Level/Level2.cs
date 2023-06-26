using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour
{
    public GameObject image;
    public GameObject level;
    void Start()
    {
       
    }

    private void OnMouseDown()
    {
        image.SetActive(true);
        LevelMain GetLevel = level.GetComponent<LevelMain>();
        GetLevel.level = 2;
        GetLevel.Switch();
    }
}
