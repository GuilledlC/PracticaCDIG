using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public void Salir()
    {
        SceneManager.LoadScene("Menu Principal");
    }
}
