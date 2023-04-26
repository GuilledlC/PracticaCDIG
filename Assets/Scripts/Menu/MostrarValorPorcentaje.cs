using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MostrarValorPorcentaje : MonoBehaviour
{
    private TextMeshProUGUI porcentaje;
    public TowerStats towerStats;
    void Start()
    {
        porcentaje = this.GetComponent<TextMeshProUGUI>();
    }
    
    public void ActualizarTexto(float valor)
    {
        porcentaje.text = Mathf.RoundToInt(valor * 100) + "%";
    }

    public void guardarEstadisticas()
    {
        towerStats.setPorcentajeDestuccion(int.Parse(porcentaje.text.Trim('%')));
        print(towerStats.getPorcentajeDestuccion());
    }
}
