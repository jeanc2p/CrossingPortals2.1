using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaObjeto : MonoBehaviour
{
    public bool destruirConCursor;
    public bool destruirAutomatico;
    public LogicaPersonaje1 logicaPersonaje1;

    public int tipo;
    

    //1 = crece
    //2 = aumenta velocidad
    //3 = aumenta salto
    // Start is called before the first frame update
    void Start()
    {
        logicaPersonaje1 = GameObject.FindGameObjectWithTag("Player").GetComponent<LogicaPersonaje1>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Efecto()
    {
        switch (tipo)
        {
            case 1:
               logicaPersonaje1.gameObject.transform.localScale = new Vector3(3, 3, 3);
               break;

            case 2:
                logicaPersonaje1.velocidadInicial += 5;
                break;

            case 3:
                logicaPersonaje1.fuerzaDeSalto += 10;
                break;


            default:
                Debug.Log("sin efecto");
                break;         



            }
     }


}
