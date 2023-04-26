using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GuardarValorAnchoRectangulo : MonoBehaviour
{
    private TextMeshProUGUI ancho;
    public TowerStats towerStats;
    void Start()
    {
        ancho = this.GetComponent<TextMeshProUGUI>();
    }

    public void GuardarEstadisticas()
    {
        if (towerStats.getRectangulo())
        {
            //Eliminar el último caracter de la caja, ya que es extraño
            int longitud = ancho.text.Length;
            towerStats.setAncho(int.Parse(ancho.text.Trim(ancho.text[longitud - 1])));
        }
    }
}
