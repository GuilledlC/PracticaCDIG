using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarValorPorcentaje : MonoBehaviour
{
    private Text porcentaje;

    void Start()
    {
        porcentaje = this.GetComponent<Text>();
    }

    
    public void ActualizarTexto(float valor)
    {
        porcentaje.text = Mathf.RoundToInt(valor * 100) + "%";
    }
}
