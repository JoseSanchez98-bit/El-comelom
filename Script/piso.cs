using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piso : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "chatarra")
        {
            Destroy(obj.gameObject);
            Debug.Log("chatarra");
        }
        if (obj.tag == "comida")
        {
            Destroy(obj.gameObject);
            Debug.Log("comida");
        }
    }
}
