using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public GameObject player;
    public GameObject flyRoach;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        flyRoach.SetActive(true);
        flyRoach.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - 0.1f);
        player.transform.position = new Vector3(this.transform.position.x, player.transform.position.y, player.transform.position.z);
        flyRoach.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - 0.1f);
        StartCoroutine(Wait());
    }
    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.09f);
        flyRoach.SetActive(false);
    }
}
