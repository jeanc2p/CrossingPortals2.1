using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaCogerObjetos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray,out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "objeto" && hitInfo.collider.gameObject.GetComponent<LogicaObjeto>().destruirConCursor == true)
                {
                   // Debug.Log(hitInfo.collider.gameObject.tag);
                    hitInfo.collider.gameObject.GetComponent<LogicaObjeto>().Efecto();
                    Destroy(hitInfo.collider.gameObject);
                }
            }

        }      

    }
    
    private void OnTriggerStay(Collider other)
    {
       // Debug.Log(other.tag);

        if (other.tag == "objeto" && other.GetComponent<LogicaObjeto>().destruirAutomatico == true)
        {
            other.GetComponent<LogicaObjeto>().Efecto();
            Destroy(other.gameObject);
        }

        if (other.tag == "objeto")
        {
            if (Input.GetMouseButtonDown(1) && other.GetComponent<LogicaObjeto>().destruirConCursor == false )
            {
                other.GetComponent<LogicaObjeto>().Efecto();
                Destroy(other.gameObject);
            }
        }


    }


}
