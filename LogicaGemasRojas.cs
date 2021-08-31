using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaGemasRojas : MonoBehaviour
{

    public LogicaNPC logicaNPC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")//si choca con algo que tenga esa etiqueta
        {
            logicaNPC.numDeObjetivos--;
            logicaNPC.textoMision.text = "Obtén las gemas " + "\n Restantes:" + logicaNPC.numDeObjetivos;

       
           
            if (logicaNPC.numDeObjetivos <= 0)
            {
                //logicaPersonaje1.nivelPersonaje++;
                logicaNPC.textoMision.text = "Completaste la misión";
                logicaNPC.botonDeMision.SetActive(true);

            }
            transform.parent.gameObject.SetActive(false);//los desactiva en vez de destruir

        }
    }


}
