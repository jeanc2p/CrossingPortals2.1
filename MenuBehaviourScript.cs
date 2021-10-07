using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{ 
    public void EmpezarJuego()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//escene2game1
        SceneManager.LoadScene("escene2game1");
    }

    public void CerrarJuego()
    {

        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
       // if (object.ontriggerCollider)
        // Debug.Log("Salir");
    }
}
