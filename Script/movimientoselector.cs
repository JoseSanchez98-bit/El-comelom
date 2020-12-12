using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoselector : MonoBehaviour
{
    // Start is called before the first frame update
   
    
        public float velocidad = 0f;
        public float lecturaeje;
        public Vector3 movimiento;
    

    // Update is called once per frame
    void Update()
    {
        lecturaeje = Input.GetAxis("Horizontal");
        movimiento = Vector3.forward * lecturaeje * velocidad;
        transform.position = transform.position + movimiento;
    }

}
