using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;


public class LogicaNPC : MonoBehaviour
{

    public GameObject simboloMision; //representa si hay una misión
    public LogicaPersonaje1 jugador;
    public GameObject panelNPC;
    public GameObject panelNPC2;
    public GameObject panelNPCMision;
    public TextMeshProUGUI textoMision;
    public bool jugadorCerca;
    public bool aceptarMision;
    public GameObject[] objetivos;
    public int numDeObjetivos;
    public GameObject botonDeMision;// misioncompleta

    // Start is called before the first frame update
    void Start()
    {
        numDeObjetivos = objetivos.Length;
        textoMision.text = "Obtén las gemas rojas" + "\n Restantes: " + numDeObjetivos;


        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<LogicaPersonaje1>();
        //target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        //jugador = GameObject.FindGameObjectsWithTag("Player").GetComponent<LogicaPersonaje1>();
        simboloMision.SetActive(true);//activate simbolo sobre el npc

        panelNPC.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && aceptarMision == false && jugador.puedoSaltar == true)

        {
            Vector3 positionJugador = new Vector3(transform.position.x, jugador.gameObject.transform.position.y, transform.position.z);
            jugador.gameObject.transform.LookAt(positionJugador);//al presionar x el personaje mira el npc


            //x y y sean cero para que no se mueva cuando hable con el NPC
            jugador.anim.SetFloat("VelX", 0);
            jugador.anim.SetFloat("VelY", 0);

            jugador.enabled = false;//desabilitamos el código para que no haga nada por ahora. 
            panelNPC.SetActive(false);
            panelNPC2.SetActive(true);


        }

    }

    private void OnTriggerEnter(Collider other)//other sería el jugador en este caso
    {
        if (other.tag == "Player")
        {
            jugadorCerca = true;
            if (aceptarMision == false)
            {
                panelNPC.SetActive(true); //se activa el panel principal
            }

        }


    }



    private void OnTriggerExit(Collider other)//al salir del area del NPC
    {
        if (other.tag == "Player")
        {
            jugadorCerca = false;
            panelNPC.SetActive(false);
            panelNPC2.SetActive(false);


        }
    }


    public void No()//no acepto mision
    {
        jugador.enabled = true;
        panelNPC.SetActive(false);
        panelNPC2.SetActive(true);

    }

    public void Si()//acepto mision

    {
        jugador.enabled = true;
        aceptarMision = true;
        //aqui se activan todas las gemas
        for (int i = 0; i < objetivos.Length; i++)
        {
            objetivos[i].SetActive(true);
        }
        jugadorCerca = false;
        simboloMision.SetActive(false);
        panelNPC.SetActive(false);
        panelNPC2.SetActive(false);
        panelNPCMision.SetActive(true);
        //se desactivan todos los paneles excepto el de la mision
    }










}
