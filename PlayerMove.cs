using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove: MonoBehaviour
{
    Rigidbody rb;
    public float velocidad = 100;

    
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0 ,movimientoVertical);
        rb.AddForce(movimiento * velocidad);
    }

}
