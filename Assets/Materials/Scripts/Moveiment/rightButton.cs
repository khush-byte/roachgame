using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightButton : MonoBehaviour
{
    public GameObject right1;
    public GameObject right2;
    public GameObject level;

    // Start is called before the first frame update
    void Start()
    {
        right1.SetActive(false);
    }

    private void OnMouseUp()
    {
        LevelMain GetLevel = level.GetComponent<LevelMain>();
        
        if (GetLevel.level > 0)
        {
            right1.SetActive(true);
            right2.SetActive(false);
        }
    }
}
