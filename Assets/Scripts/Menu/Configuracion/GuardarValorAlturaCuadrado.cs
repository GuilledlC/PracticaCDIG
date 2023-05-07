using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GuardarValorAlturaCuadrado : MonoBehaviour
{
    private TextMeshProUGUI altura;
    public TowerStats towerStats;
    void Start()
    {
        altura = this.GetComponent<TextMeshProUGUI>();
    }

    public void GuardarEstadisticas()
    {
        if (towerStats.getCuadrado())
        {
            //Eliminar el último caracter de la caja, ya que es extraño
            int longitud = altura.text.Length;
            towerStats.setAlturaC(int.Parse(altura.text.Trim(altura.text[longitud - 1])));   
        }
    }
}
