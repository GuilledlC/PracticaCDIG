using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GuardarValorAltura : MonoBehaviour
{
    private TextMeshProUGUI altura;
    public TowerStats towerStats;
    void Start()
    {
        altura = this.GetComponent<TextMeshProUGUI>();
    }

    public void GuardarEstadisticas()
    {
        //Eliminar el último caracter de la caja, ya que es extraño
        if (!towerStats.getCuadrado())
        {
            int longitud = altura.text.Length;
            towerStats.setAlturaR(int.Parse(altura.text.Trim(altura.text[longitud - 1])));
        }
    }
}
