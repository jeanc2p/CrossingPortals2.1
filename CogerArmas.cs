using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerArmas : MonoBehaviour
{

    public GameObject[] armas;
    public BoxCollider[] armasBoxColl;
    public BoxCollider puñoBoxColl;

    public LogicaPersonaje1 logicaPersonaje1;

    // Start is called before the first frame update
    void Start()
    {
        DesactivarColliderArmas();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        { DesactivarArmas();
        
        }


    }


    public void ActivarArmas(int numero)
    {
        for (int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
        }

        armas[numero].SetActive(true);


        logicaPersonaje1.conArma = true;
    }

    public void DesactivarArmas()
    {
        for (int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
        }

        // armas[numero].SetActive(true);
        logicaPersonaje1.conArma = false;
    }


    public void ActivarColliderArmas()
    {
        for (int i = 0; i<armasBoxColl.Length;i++)
        {
            if (logicaPersonaje1.conArma)
            {
                if (armasBoxColl[i] != null)
                {
                    armasBoxColl[i].enabled = true;
                }
            }
            else
            {
                puñoBoxColl.enabled = true;
            }

        }

    }


    public void DesactivarColliderArmas()
    {

        for (int i = 0; i <armasBoxColl.Length;i++)
        {
            if (armasBoxColl[i] != null)
            {
                armasBoxColl[i].enabled = false;

            }
        }
        puñoBoxColl.enabled = false;
    }

}
