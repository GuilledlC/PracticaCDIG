using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptParedLadrillo : MonoBehaviour
{
    public int lado1;
    public int lado2;
    public int altura;

    public GameObject Ladrillo;
    public GameObject LadrilloBase;
    
    private Vector3 posicion = new Vector3(0, -12f, 11);
    private readonly Vector3 desplazamientoX = new Vector3(2f, 0, 0);
    private readonly Vector3 desplazamientoZ = new Vector3(0, 0, 2f);
    private readonly Vector3 desplazamientoY = new Vector3(0, 1, 0);

    private readonly Quaternion rotacionX = new Quaternion(0, 0, 0, 0);
    private readonly Quaternion rotacionZ = new Quaternion(0.1f, 0, 0.1f, 0);


    void Start()
    {
        CargarEstructura();
    }

    private void CargarEstructura()
    {
        posicion -= (desplazamientoX / 2) * (lado1 - 1.5f);
        posicion -= (desplazamientoZ / 2) * (lado2);
        
        //Estructura
        for (int i = 0; i < altura; ++i)
        {
            if (i % 2 == 0)
                CargarPiso1(Ladrillo, Vector3.up * 0.1f);
            else
                CargarPiso0(Ladrillo, Vector3.up * 0.1f);
            posicion += desplazamientoY;
        }
    }

    private void CargarPiso0(GameObject objeto, Vector3 offset)
    {
        for (int i = 0; i < lado1; ++i)
        {
            GameObject foo = Instantiate(objeto, posicion + offset, rotacionX, transform);
            foo.GetComponent<MeshRenderer>().enabled = true;
            posicion += desplazamientoX;
        }

        posicion -= (0.75f * desplazamientoX) - (0.75f * desplazamientoZ);

        for (int i = 0; i < lado2; ++i)
        {
            GameObject foo = Instantiate(objeto, posicion + offset, rotacionZ, transform);
            foo.GetComponent<MeshRenderer>().enabled = true;
            posicion += desplazamientoZ;
        }

        posicion -= (0.75f * desplazamientoZ) + (0.75f * desplazamientoX);

        for (int i = 0; i < lado1; ++i)
        {
            GameObject foo = Instantiate(objeto, posicion + offset, rotacionX, transform);
            foo.GetComponent<MeshRenderer>().enabled = true;
            posicion -= desplazamientoX;
        }

        posicion += (0.75f * desplazamientoX) - (0.75f * desplazamientoZ);

        for (int i = 0; i < lado2; ++i)
        {
            GameObject foo = Instantiate(objeto, posicion + offset, rotacionZ, transform);
            foo.GetComponent<MeshRenderer>().enabled = true;
            posicion -= desplazamientoZ;
        }

        posicion += (0.75f * desplazamientoZ) + (0.25f * desplazamientoX);
    }

    private void CargarPiso1(GameObject objeto, Vector3 offset)
    {
        for (int i = 0; i < lado1; ++i)
        {
            GameObject foo = Instantiate(objeto, posicion + offset, rotacionX, transform);
            foo.GetComponent<MeshRenderer>().enabled = true;
            posicion += desplazamientoX;
        }

        posicion -= (0.25f * desplazamientoX) - (0.25f * desplazamientoZ);

        for (int i = 0; i < lado2; ++i)
        {
            GameObject foo = Instantiate(objeto, posicion + offset, rotacionZ, transform);
            foo.GetComponent<MeshRenderer>().enabled = true;
            posicion += desplazamientoZ;
        }

        posicion -= (0.25f * desplazamientoZ) + (0.25f * desplazamientoX);

        for (int i = 0; i < lado1; ++i)
        {
            GameObject foo = Instantiate(objeto, posicion + offset, rotacionX, transform);
            foo.GetComponent<MeshRenderer>().enabled = true;
            posicion -= desplazamientoX;
        }

        posicion += (0.25f * desplazamientoX) - (0.25f * desplazamientoZ);

        for (int i = 0; i < lado2; ++i)
        {
            GameObject foo = Instantiate(objeto, posicion + offset, rotacionZ, transform);
            foo.GetComponent<MeshRenderer>().enabled = true;
            posicion -= desplazamientoZ;
        }

        posicion += (0.25f * desplazamientoZ) + (0.75f * desplazamientoX);
    }
} 