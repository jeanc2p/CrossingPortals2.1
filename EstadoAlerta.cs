using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoAlerta : MonoBehaviour
{
    public float VelocidadGiroBusqueda = 120f;
    public float DuracionBusqueda = 2f;

    private MaquinaDeEstados maquinaDeEstados;
    private ControladorVision controladorVision;
    private ControladorNavMesh controladorNavMesh;
    private float tiempoBuscando;
    private Animator animator;

    private void Awake()
    {
        controladorVision = GetComponent<ControladorVision>();
        controladorNavMesh = GetComponent<ControladorNavMesh>();
        maquinaDeEstados = GetComponent<MaquinaDeEstados>();
        animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        controladorNavMesh.DetenerNavMeshAgent();

        animator.SetBool("Run", false);
        animator.SetBool("walk", false);
        animator.SetBool("Idle", true);

        tiempoBuscando = 0f;
    }

    private void Update()
    {
        if (controladorVision.PuedeVerAlJugador(out RaycastHit hit))
        {
            controladorNavMesh.PerseguirObjetivo = hit.transform;
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoPersecucion);
            return;
        }

        transform.Rotate(0f,VelocidadGiroBusqueda*Time.deltaTime,0f);
        tiempoBuscando += Time.deltaTime;

        if(tiempoBuscando>=DuracionBusqueda)
        {
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoPatrulla);
            return;
        }
    }
}
