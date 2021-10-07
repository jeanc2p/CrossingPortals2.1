using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuertasCubo4 : MonoBehaviour
{
    public GameObject[] Puertas;


    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.tag == "Player")
        {

            Destroy(gameObject);
            for (int i = 0; i < Puertas.Length; i++)
            {
                Puertas[i].SetActive(false);
            }


        }


         
    }
}
