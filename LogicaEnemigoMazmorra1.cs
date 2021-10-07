using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEnemigoMazmorra1 : MonoBehaviour
{


    public int hp;
    public int damageArma;
    public int damageFist;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    
    private void OntriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "armaImpacto")
        {
            if (anim != null)
            {
              anim.Play("EnemigoMaz1");

            }
            Destroy(gameObject);
             hp -= damageArma;
        }
        if (other.gameObject.tag == "golpeImpacto")
        {
            if (anim != null)
            {
             anim.Play("EnemigoMaz1");

            }
            hp -= damageFist;


            Destroy(gameObject);

             }
             if (hp <= 0 )
             {
                 Destroy(gameObject);
             }


        }



    

        }
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
