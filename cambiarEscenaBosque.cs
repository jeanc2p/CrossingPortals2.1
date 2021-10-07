using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cambiarEscenaBosque : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("SampleScene1Menu");//Menu
        }

    }
}
