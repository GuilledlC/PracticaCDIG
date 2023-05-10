using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NumPajarotos : MonoBehaviour
{
    private TextMeshProUGUI valor;
    private int resultado = 0;

    public TowerStats towerStats;
    void Start()
    {
        valor = this.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        valor.text = towerStats.pajarotos.ToString();
    }
}
