using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaPersonaje1 : MonoBehaviour

{
    public bool conArma;

    // Start is called before the first frame update
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotación = 250.0f;

    public int velCorrer;

    //caer faster
    public int fuerzaExtra=0;



    //to change el collider
    public CapsuleCollider colParado;
    public CapsuleCollider colAgachado;
    public GameObject cabeza;

    public LogicaCabeza logicaCabeza;
    public bool estoyAgachado;


    public Animator anim; 
    public float x, y;

    public Rigidbody rB;
    public float fuerzaDeSalto = 10.0f;
    public bool puedoSaltar;

    public float velocidadInicial;
    public float velocidadAgachado;

    public bool estoyAtacando;
    public bool avanzoSolo;
    public float impulsoDeGolpe = 4f;


   // public int nivelPersonaje = 1;




    void Start()
    {


        puedoSaltar = false;
        anim = GetComponent<Animator>();

        velocidadInicial = velocidadMovimiento;
        velocidadAgachado = velocidadMovimiento * 0.5f;

    }

    private void FixedUpdate()
    {
        if (!estoyAtacando)
        {
            transform.Rotate(0, x * Time.deltaTime * velocidadRotación, 0);
            transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
        }
        if (avanzoSolo)
        {
            rB.velocity = transform.forward * impulsoDeGolpe;
        }
          

    }




    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift) && !estoyAgachado  && puedoSaltar && !estoyAtacando)
        {

            velocidadMovimiento = velCorrer;
            if (y>0)
            {
                anim.SetBool("correr", true);

            }
            else
            {
                anim.SetBool("correr", false);
            }
        }
        else
        {

            anim.SetBool("correr", false);
            if (estoyAgachado)
            {
                velocidadMovimiento = velocidadAgachado;
            }
            else if (puedoSaltar)
            {
                velocidadMovimiento = velocidadInicial;
            }
        }



        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");


        // aquí iba las anteriores funciones pero las cambiaos arriba.

        if (Input.GetKeyDown(KeyCode.Return) && puedoSaltar && !estoyAtacando)
        {
            if (conArma)
            {
                anim.SetTrigger("golpeo2");
                estoyAtacando = (true);

            }
            else
            {

                anim.SetTrigger("golpeo");
                estoyAtacando = true;

            }

        }


        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

          
        if (puedoSaltar)
        {
            if (!estoyAtacando)
            {
                if (Input.GetKeyDown(KeyCode.Space))

                {
                    anim.SetBool("salte", true);
                    rB.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
                }

                if (Input.GetKey(KeyCode.LeftControl))

                {
                    anim.SetBool("agachado", true);
                    //velocidadMovimiento = velocidadAgachado;

                    //also para el collider
                    colAgachado.enabled = true;
                    colParado.enabled = false;

                    cabeza.SetActive(true);
                    estoyAgachado = true;


                }

                else
                { 
                    if (logicaCabeza.contDeColision <= 0)
                    {
                     anim.SetBool("agachado", false);
                    //velocidadMovimiento = velocidadInicial;

                        //again para el collider
                        cabeza.SetActive(false);
                        colAgachado.enabled = false;
                        colParado.enabled = true;
                        estoyAgachado = false;


                    }

                   
                }
            }
            anim.SetBool("tocoSuelo", true);
        }

        else
        {
            EstoyCayendo();
        }
    }

    public void EstoyCayendo()
    {

        //fall faster
        rB.AddForce(fuerzaExtra * Physics.gravity);
        anim.SetBool("tocoSuelo", false);
        anim.SetBool("salte", false);
    }


    public void DejeDeGolpear()
    {
        estoyAtacando = false;
    }


    public void AvanzoSolo()
    {
        avanzoSolo = true;
    }


    public void DejoDeAvanzar()
    {
        avanzoSolo = false;
    }
}
