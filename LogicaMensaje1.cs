using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicaMensaje1 : MonoBehaviour
{

    public GameObject uiObject;


    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }


    IEnumerator WaitForSec()
    {

    yield  return new WaitForSeconds(5);
    Destroy(uiObject);
    Destroy(gameObject);
    }


}
