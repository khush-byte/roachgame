using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnPlay : MonoBehaviour
{
    private void OnMouseDown()
    {
        SpriteRenderer color = gameObject.GetComponent<SpriteRenderer>();
        color.color = Color.grey;
    }

    private void OnMouseUp()
    {        
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
