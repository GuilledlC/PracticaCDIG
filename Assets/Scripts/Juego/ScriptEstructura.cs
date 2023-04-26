using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEstructura : MonoBehaviour
{
    public int lado1;
    public int lado2;
    public int altura;

    public GameObject Ladrillo;
    public GameObject LadrilloFantasma;

    private Vector3 posicion = new Vector3(0, 0.5F, 0);
    private readonly Vector3 desplazamientoX = new Vector3(2f, 0, 0);
    private readonly Vector3 desplazamientoZ = new Vector3(0, 0, 2f);
    private readonly Vector3 desplazamientoY = new Vector3(0, 1, 0);

    private readonly Quaternion rotacionX = new Quaternion(0, 0, 0, 0);
    private readonly Quaternion rotacionZ = new Quaternion(0.1f, 0, 0.1f, 0);

    // Start is called before the first frame update
    void Start()
    {
        CargarEstructura();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CargarEstructura()
    {
        posicion -= (desplazamientoX/2) * (lado1 - 1.5f);
        posicion -= (desplazamientoZ/2) * (lado2);
        
        for (int i = 0; i < altura; ++i)
        {
            if(i%2 == 0)
                CargarPiso0();
            else
                CargarPiso1();
            posicion += desplazamientoY;
        }
    }
    
    private void CargarPiso0()
    {
        for (int i = 0; i < lado1; ++i)
        {
            Crear(posicion, rotacionX);
            posicion += desplazamientoX;
        }
        posicion -= (0.75f * desplazamientoX) - (0.75f * desplazamientoZ);
        
        for (int i = 0; i < lado2; ++i)
        {
            Crear(posicion, rotacionZ);
            posicion += desplazamientoZ;
        }
        posicion -= (0.75f * desplazamientoZ) + (0.75f * desplazamientoX);
        
        for (int i = 0; i < lado1; ++i)
        {
            Crear(posicion, rotacionX);
            posicion -= desplazamientoX;
        }
        posicion += (0.75f * desplazamientoX) - (0.75f * desplazamientoZ);
        
        for (int i = 0; i < lado2; ++i)
        {
            Crear(posicion, rotacionZ);
            posicion -= desplazamientoZ;
        }
        posicion += (0.75f * desplazamientoZ) + (0.25f * desplazamientoX);

    }
    
    private void CargarPiso1()
    {
        for (int i = 0; i < lado1; ++i)
        {
            Crear(posicion, rotacionX);
            posicion += desplazamientoX;
        }
        posicion -= (0.25f * desplazamientoX) - (0.25f * desplazamientoZ);
        
        for (int i = 0; i < lado2; ++i)
        {
            Crear(posicion, rotacionZ);
            posicion += desplazamientoZ;
        }
        posicion -= (0.25f * desplazamientoZ) + (0.25f * desplazamientoX);
        
        for (int i = 0; i < lado1; ++i)
        {
            Crear(posicion, rotacionX);
            posicion -= desplazamientoX;
        }
        posicion += (0.25f * desplazamientoX) - (0.25f * desplazamientoZ);
        
        for (int i = 0; i < lado2; ++i)
        {
            Crear(posicion, rotacionZ);
            posicion -= desplazamientoZ;
        }
        posicion += (0.25f * desplazamientoZ) + (0.75f * desplazamientoX);
    }
    
    private void Crear(Vector3 posicion, Quaternion rotacion)
    {
        Instantiate(Ladrillo, posicion, rotacion);
        Instantiate(LadrilloFantasma, posicion, rotacion);
    }
}
