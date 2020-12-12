using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class comelon : MonoBehaviour
{
    public float vida;
    public float puntos;
    public GameObject personaje;
    public float puntosnesesarios;
    public float puntosnesesarios2;
    public float puntosnesesarios3;
    public AudioClip guacala;
    public AudioClip comer;
    public Slider barravida;
    public Slider barrapuntos;
    AudioSource aqui;

    // Start is called before the first frame update
    void Start()
    {
        aqui = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        barravida.value = vida;
        barrapuntos.value = puntos;
    }

    
    private void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "chatarra")
        {
            aqui.clip = guacala;
            aqui.Play();
            vida -= 1;
            Destroy(obj.gameObject);
            Debug.Log("comi chatarra");
        }
        if (obj.tag == "comida")
        {
            aqui.clip = comer;
            aqui.Play();
            puntos += 1;
            Destroy(obj.gameObject);
            Debug.Log("comi comida");
        }

        if (vida == 0)
        {
            Destroy(personaje);
            SceneManager.LoadSceneAsync("menu derrota");
        }

        if (puntos == puntosnesesarios)
        {
            Destroy(personaje);
            SceneManager.LoadSceneAsync("menu victoria");
        }

        if (puntos == puntosnesesarios2)
        {
            Destroy(personaje);
            SceneManager.LoadSceneAsync("menu victoria 2");
        }
        if (puntos == puntosnesesarios3)
        {
            Destroy(personaje);
            SceneManager.LoadSceneAsync("menu victoria 3");
        }
    }

}
    

