using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerPuertas5 : MonoBehaviour
{
    public GameObject Camara;
    public GameObject Camara2;
    public GameObject[] Puertas;
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        Destroy(gameObject);
        for (int i = 0; i < Puertas.Length; i++)
        {
            Puertas[i].SetActive(false);
        }

        Invoke(nameof(EnfocarCamara), 3.0f);

    }

    
    public void EnfocarCamara()
    {
        Camara2.SetActive(true);
        Camara.SetActive(false);
       
    }
}
