using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EstadoPersecucion : MonoBehaviour
{
    private Animator animator;
    private ControladorNavMesh controladorNavMesh;
    private ControladorVision controladorVision;
    private MaquinaDeEstados maquinaDeEstados;
    public EnRango enRango;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        controladorNavMesh = GetComponent<ControladorNavMesh>();
        controladorVision = GetComponent<ControladorVision>();
        maquinaDeEstados = GetComponent<MaquinaDeEstados>();
        
        
    }
    // Start is called before the first frame update
    private void OnEnable()
    {
        animator.SetBool("walk",false);
        animator.SetBool("Idle", false);
        animator.SetBool("Run",true);
    }
    private void Update()
    {
        controladorNavMesh.ActualizarPuntoDestinoNavMesh();
        if (!controladorVision.PuedeVerAlJugador(out RaycastHit hit, true))
        {
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoAlerta);
            return;
        }

        if (enRango.Enrango)
        {
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoAtaque);
        }


    }
}
