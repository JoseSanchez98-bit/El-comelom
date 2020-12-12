using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class COMANDOSBASICOS : MonoBehaviour
{
    public void cargarescena(string nombredeescena)
    {
        SceneManager.LoadSceneAsync(nombredeescena);
    }
    public void salir()
    {
        Application.Quit();
        Debug.Log("ya saliste");
    }
}
