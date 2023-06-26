using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnAgain : MonoBehaviour
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
