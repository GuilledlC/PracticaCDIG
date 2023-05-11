using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPrincipal : MonoBehaviour
{
    public TowerStats stats;
    public void Jugar()
    {
        SceneManager.LoadScene("Juego");
        stats.pajarotos = 0;
        stats.destruidos = 0;
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }
    
    public void Salir()
    {
        Application.Quit();
    }
}
