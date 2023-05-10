using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PorcentajeDestruccion : MonoBehaviour
{
    private TextMeshProUGUI valor;
    private int resultado = 0;
    public GameObject rectangulo;
    public GameObject cuadrado;

    public TowerStats towerStats;
    void Start()
    {
        valor = this.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (rectangulo.GetComponent<MeshRenderer>().enabled)
        {
            resultado = Mathf.RoundToInt((towerStats.destruidos / (float) towerStats.totalR) * 100);
            valor.text = resultado + "%";
        }
        else if (cuadrado.GetComponent<MeshRenderer>().enabled)
        {
            resultado = Mathf.RoundToInt((towerStats.destruidos / (float) towerStats.totalC) * 100);
            valor.text = resultado + "%";
        }
        else
        {
            valor.text = "NO";
        }

        if (towerStats.getPorcentajeDestuccion() <= resultado)
        {
            SceneManager.LoadScene("Menu Principal");
        }
    }
}
