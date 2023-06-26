using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
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
        GetLevel.level = 1;
        GetLevel.Switch();
    }
}
