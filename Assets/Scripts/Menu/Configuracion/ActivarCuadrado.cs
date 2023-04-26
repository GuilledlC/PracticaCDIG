using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCuadrado : MonoBehaviour
{
    public TowerStats towerStats;

    public void cambiarEstadoACuadrado()
    {
        towerStats.setRectangulo(false);
    }
}
