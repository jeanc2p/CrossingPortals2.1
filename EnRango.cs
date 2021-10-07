using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnRango : MonoBehaviour
{
   public bool Enrango;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Enrango = true;
            Debug.Log("Sisasssss");






        }
    }

}
