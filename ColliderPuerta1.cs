using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPuerta1 : MonoBehaviour
{
    public GameObject Puerta;
    private void OnTriggerEnter(UnityEngine.Collider other)
    {


        if (other.tag == "Player")
        {
            Destroy(gameObject);
            Puerta.SetActive(false);

        }
           
    }
}