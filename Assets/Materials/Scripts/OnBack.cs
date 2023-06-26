using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnBack : MonoBehaviour
{
    private void OnMouseDown()
    {
        SpriteRenderer color = gameObject.GetComponent<SpriteRenderer>();
        color.color = Color.blue;
    }
    private void OnMouseUp()
    {
        SpriteRenderer color = gameObject.GetComponent<SpriteRenderer>();
        color.color = Color.clear;
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
