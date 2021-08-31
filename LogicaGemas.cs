using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LogicaGemas : MonoBehaviour   
{
    public int numDeObjetivos;
    public TextMeshProUGUI textoMision;
    public GameObject botonDeMision;

   // public LogicaPersonaje1 logicaPersonaje1;

    // Start is called before the first frame update
    void Start()
    {
        numDeObjetivos = GameObject.FindGameObjectsWithTag("objetivo").Length;
        textoMision.text = ("Obtén las gemas rojas" + "\n restantes:") + numDeObjetivos;


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "objetivo")
        {
            Destroy(col.transform.parent.gameObject);
            numDeObjetivos--;
            textoMision.text = "Obten las gemas rojas" + "\n Restantes:" + numDeObjetivos;
            if (numDeObjetivos <= 0)
            {
                //logicaPersonaje1.nivelPersonaje++;
                textoMision.text = "Completaste la misión";
                botonDeMision.SetActive(true);
            }

        }
    }



}
