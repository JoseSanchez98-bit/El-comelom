using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sueltacomida : MonoBehaviour
{
    public Rigidbody comida;
    public Transform lanzador;
    public int tiempo;
    public bool lanzar = false;
    public float sueltala;
    public float ahora;

    // Start is called before the first frame update
    void Start()
    {


    }

    private void Update()
    {
        if (lanzar == false)
        {
            StartCoroutine("suelta");
        }

        if (lanzar == true && Time.time > sueltala)
        {
            sueltala = Time.time + ahora;
            Instantiate(comida, lanzador.position, Quaternion.identity);
            Debug.Log("soltado");
            lanzar = false;
        }
    }

    IEnumerator suelta()
    {
        yield return new WaitForSeconds(tiempo);
        lanzar = true;
        Debug.Log("sicae");
    }

}
