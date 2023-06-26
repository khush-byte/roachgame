using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachDead : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnBecameVisible()
    {
        StartCoroutine(Dead());
    }
    public IEnumerator Dead()
    {
        do
        {
            transform.localScale = new Vector2(transform.localScale.x + 0.01f, transform.localScale.y + 0.01f);
            yield return new WaitForSeconds(0.09f);
        } while (transform.localScale.x < 1.1f) ;       
    }
}
