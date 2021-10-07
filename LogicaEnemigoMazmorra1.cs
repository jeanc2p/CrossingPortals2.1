using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEnemigoMazmorra1 : MonoBehaviour
{


    public int hp;
    public int damageArma;
    public int damageFist;



    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
    
    }
         




    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "golpeImpacto")
        {
            Destroy(gameObject);
        }


        if (other.tag == "armaImpacto")
        {
            Destroy(gameObject);
        }
    }



}

