using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Volver : MonoBehaviour
{
    public void VolverAlMenu()
    {
        SceneManager.LoadScene("Menu Principal");
    }
}
