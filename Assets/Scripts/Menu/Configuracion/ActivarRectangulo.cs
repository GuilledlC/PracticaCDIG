using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarRectangulo : MonoBehaviour
{
    public TowerStats towerStats;

    public void cambiarEstadoARectangulo()
    {
        towerStats.setRectangulo(true);
    }
}
