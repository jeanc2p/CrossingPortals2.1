using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour
{
    public GameObject Sphere;
    private Vector3 PosicionRelativa;

    void Start()
    {
        PosicionRelativa = transform.position - Sphere.transform.position; 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Sphere.transform.position + PosicionRelativa;
    }
}
