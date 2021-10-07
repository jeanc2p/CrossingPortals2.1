using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorVision : MonoBehaviour
{
    public Transform Ojos;
    public float RangoVision = 40f;
    public Vector3 Offset = new Vector3(0f,0.5f,0f); 

    private ControladorNavMesh controladorNavMesh;
    // Start is called before the first frame update

    private void Awake()
    {
        controladorNavMesh = GetComponent<ControladorNavMesh>();
    }
    public bool PuedeVerAlJugador(out RaycastHit hit,bool mirarHaciaElJugador= false)
    {
        Vector3 vectorDireccion;
        if(mirarHaciaElJugador)
        {
            vectorDireccion = controladorNavMesh.PerseguirObjetivo.position + Offset - Ojos.position;
        }
        else
        {
            vectorDireccion = Ojos.forward;
        }

        return Physics.Raycast(Ojos.position, vectorDireccion, out hit, RangoVision) && hit.collider.CompareTag("Player"); ;
    }
}
