using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPies : MonoBehaviour

{
    public LogicaPersonaje1 logicaPersonaje1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerStay(Collider other)

    {
        if (other.tag == "piso" || other.tag == "objeto")
        {
            logicaPersonaje1.puedoSaltar = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        logicaPersonaje1.puedoSaltar = false;

        
    }
}

