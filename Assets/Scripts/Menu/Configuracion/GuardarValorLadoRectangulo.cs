using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GuardarValorLadoRectangulo : MonoBehaviour
{
    private TextMeshProUGUI lado;
    public TowerStats towerStats;
    void Start()
    {
        lado = this.GetComponent<TextMeshProUGUI>();
    }

    public void GuardarEstadisticas()
    {
        if (!towerStats.getCuadrado())
        {
            //Eliminar el último caracter de la caja, ya que es extraño
            int longitud = lado.text.Length;
            towerStats.setLado(int.Parse(lado.text.Trim(lado.text[longitud - 1]))); 
        }
    }
}
