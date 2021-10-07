using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoAtaque : MonoBehaviour
{
    private Animator Ani;
    public EnRango enRango;
    private MaquinaDeEstados maquinaDeEstados;
    public GameObject ColliderAtaque;
    private bool FueraDeRango;

    private void Awake()
    {
        Ani = GetComponent<Animator>();
        maquinaDeEstados = GetComponent<MaquinaDeEstados>();
    }

    private void OnEnable()
    {
        CodigoAtaque();
    }
    public void CodigoAtaque(){

        Ani.SetBool("Idle", false);
        Ani.SetBool("Run", false);
        Ani.SetBool("attack", true);

        ColliderAtaque.GetComponent<CapsuleCollider>().enabled = false;
    }

    public void FinalAni()
    {
        Ani.SetBool("attack",false);
        enRango.Enrango = false;
        ColliderAtaque.GetComponent<CapsuleCollider>().enabled=true;
        FueraDeRango = true;

    }
    private void Update()
    {
        if (FueraDeRango)
        {
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoAlerta);
        }
    }

}
