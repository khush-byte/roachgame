using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftButton : MonoBehaviour
{
    public GameObject left1;
    public GameObject left2;

    // Start is called before the first frame update
    void Start()
    {
        left1.SetActive(false);
    }

    private void OnMouseUp()
    {
        left2.SetActive(false);
        left1.SetActive(true);
    }
}
