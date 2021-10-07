using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoPatrulla : MonoBehaviour
{
    public Transform[] WayPoints;

    private MaquinaDeEstados maquinaDeEstados;
    private ControladorNavMesh controladornavMesh;
    private int siguienteWayPoint;
    private ControladorVision controladorVision;
    private Animator animator;
    // Start is called before the first frame update
    private void Awake()
    {
        maquinaDeEstados = GetComponent<MaquinaDeEstados>();
        controladornavMesh = GetComponent<ControladorNavMesh>();
        animator = GetComponent<Animator>();
        controladorVision = GetComponent<ControladorVision>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controladorVision.PuedeVerAlJugador(out RaycastHit hit))
        {
            controladornavMesh.PerseguirObjetivo = hit.transform;
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoPersecucion);
            return;
        }

        if (controladornavMesh.Llegamos())
        {
            siguienteWayPoint = (siguienteWayPoint + 1) % WayPoints.Length;
            ActualizarVoidPointDestino();
        }
    }

    private void OnEnable()
    {
        ActualizarVoidPointDestino();
        animator.SetBool("Idle", false );
        animator.SetBool("Run", false);
        animator.SetBool("walk", true);
    }
    void ActualizarVoidPointDestino()
    {
        controladornavMesh.ActualizarPuntoDestinoNavMesh(WayPoints[siguienteWayPoint].position);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && enabled)
        {
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoAlerta);
        }
        
    }
}
