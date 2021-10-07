using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicaBarraDeVidaPersonaje1 : MonoBehaviour
{
    public int vidaMax = 100;
    public float vidaActual;
    public Image imagenBarraVida;


    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {


        RevisarVida();

        if (vidaActual <= 0)
          {
            gameObject.SetActive(false);
            SceneManager.LoadScene("escene2game1");




        }
        
    }

    public void RevisarVida()
    {
        imagenBarraVida.fillAmount = vidaActual / vidaMax;

    }
}
