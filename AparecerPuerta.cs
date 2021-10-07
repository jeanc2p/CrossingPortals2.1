using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerPuerta : MonoBehaviour
{
    public GameObject Puerta;
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        Puerta.SetActive(true);
        Destroy(gameObject);
    }
}
