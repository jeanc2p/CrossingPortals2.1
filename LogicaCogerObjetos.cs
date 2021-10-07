using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaCogerObjetos : MonoBehaviour
{


    //public bool tienePowerUp;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("RutinaTemporizadorPowerUp");
    }
    //IEnumerator RutinaTemporizadorPowerUp()
    //{
      //  yield return new WaitForSeconds(10f);
        //other.GetComponent<LogicaObjeto>().Efecto().disable();

    //}

    /* IEnumerator RutinaTemporizadorPowerUp()
   {
       yield return new WaitForSeconds(7);
       tienePowerUp = false;

   }*/

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray,out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "objetoEnemigo" && hitInfo.collider.gameObject.GetComponent<LogicaObjeto>().destruirConCursor == true)
                {
                   // Debug.Log(hitInfo.collider.gameObject.tag);
                    hitInfo.collider.gameObject.GetComponent<LogicaObjeto>().Efecto();
                    Destroy(hitInfo.collider.gameObject);
                }
            }

        }     
      


    }
    
    public void OnTriggerStay(Collider other)
    {
       // Debug.Log(other.tag);

        if (other.tag == "objetoEnemigo" && other.GetComponent<LogicaObjeto>().destruirAutomatico == true)
        {
            other.GetComponent<LogicaObjeto>().Efecto();
            Destroy(other.gameObject);
        }

        if (other.tag == "objetoEnemigo")
        {
            if (Input.GetMouseButtonDown(1) && other.GetComponent<LogicaObjeto>().destruirConCursor == false )
            {
                other.GetComponent<LogicaObjeto>().Efecto();
                Destroy(other.gameObject);
            }
        }

        //tienePowerUp = true;

      

    }


}
