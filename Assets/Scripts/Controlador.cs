using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    public int lado1;
    public int lado2;
    public int altura;

    public GameObject Ladrillo;

    private Vector3 posicionInicial = new Vector3(0, 0.5F, 0);
    private Vector3 desplazamientoX = new Vector3(2f, 0, 0);
    private Vector3 desplazamientoY = new Vector3(0, 0, 2f);

    private Quaternion rotacionX = new Quaternion(0, 0, 0, 0);
    private Quaternion rotacionY = new Quaternion(0.1f, 0, 0.1f, 0);

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial -= (desplazamientoX/2) * (lado1 - 1.5f);
        posicionInicial -= (desplazamientoY/2) * (lado2);
        for (int i = 0; i < lado1; ++i)
        {
            GameObject.Instantiate(Ladrillo, 
                posicionInicial + (i * desplazamientoX),
                rotacionX);
        }

        posicionInicial += ((lado1 - 0.75f) * desplazamientoX + (0.75f * desplazamientoY));
        for (int i = 0; i < lado2; ++i)
        {
            GameObject.Instantiate(Ladrillo, 
                posicionInicial + (i * desplazamientoY),
                rotacionY);
        }

        posicionInicial += ((lado2 - 0.75f) * desplazamientoY - (0.75f * desplazamientoX));
        for (int i = 0; i < lado1; ++i)
        {
            GameObject.Instantiate(Ladrillo, 
                posicionInicial - (i * desplazamientoX),
                rotacionX);
        }
        
        posicionInicial -= ((lado1 - 0.75f) * desplazamientoX + (0.75f * desplazamientoY));
        for (int i = 0; i < lado2; ++i)
        {
            GameObject.Instantiate(Ladrillo, 
                posicionInicial - (i * desplazamientoY),
                rotacionY);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
