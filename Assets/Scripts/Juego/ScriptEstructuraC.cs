using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEstructuraC : MonoBehaviour
{
    public TowerStats stats;
    
    private int lado;
    private int altura;
    private int total;

    public GameObject Ladrillo;
    public GameObject LadrilloBase;

    private Vector3 posicion = new Vector3(0, 0.5F, 0);
    private readonly Vector3 desplazamientoX = new Vector3(2f, 0, 0);
    private readonly Vector3 desplazamientoZ = new Vector3(0, 0, 2f);
    private readonly Vector3 desplazamientoY = new Vector3(0, 1, 0);

    private readonly Quaternion rotacionX = new Quaternion(0, 0, 0, 0);
    private readonly Quaternion rotacionZ = new Quaternion(0.1f, 0, 0.1f, 0);

    // Start is called before the first frame update
    void Start()
    {
        lado = stats.getLadoC();
        altura = stats.getAlturaC();
        this.total = lado * 4 * altura;
        CargarEstructura();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CargarEstructura()
    {
        posicion -= (desplazamientoX/2) * (lado - 1.5f);
        posicion -= (desplazamientoZ/2) * (lado);
        
        //Alfombra
        CargarPiso0(LadrilloBase, Vector3.down * 0.5f);
        
        //Estructura
        for (int i = 0; i < altura; ++i)
        {
            if(i%2 == 0)
                CargarPiso1(Ladrillo, Vector3.up * 0.1f);
            else
                CargarPiso0(Ladrillo, Vector3.up * 0.1f);
            posicion += desplazamientoY;
        }
    }
    
    private void CargarPiso0(GameObject objeto, Vector3 offset)
    {
        for (int i = 0; i < lado; ++i)
        {
            Instantiate(objeto, posicion + offset, rotacionX, transform);
            posicion += desplazamientoX;
        }
        posicion -= (0.75f * desplazamientoX) - (0.75f * desplazamientoZ);
        
        for (int i = 0; i < lado; ++i)
        {
            Instantiate(objeto, posicion + offset, rotacionZ, transform);
            posicion += desplazamientoZ;
        }
        posicion -= (0.75f * desplazamientoZ) + (0.75f * desplazamientoX);
        
        for (int i = 0; i < lado; ++i)
        {
            Instantiate(objeto, posicion + offset, rotacionX, transform);
            posicion -= desplazamientoX;
        }
        posicion += (0.75f * desplazamientoX) - (0.75f * desplazamientoZ);
        
        for (int i = 0; i < lado; ++i)
        {
            Instantiate(objeto, posicion + offset, rotacionZ, transform);
            posicion -= desplazamientoZ;
        }
        posicion += (0.75f * desplazamientoZ) + (0.25f * desplazamientoX);
    }
    
    private void CargarPiso1(GameObject objeto, Vector3 offset)
    {
        for (int i = 0; i < lado; ++i)
        {
            Instantiate(objeto, posicion + offset, rotacionX, transform);
            posicion += desplazamientoX;
        }
        posicion -= (0.25f * desplazamientoX) - (0.25f * desplazamientoZ);
        
        for (int i = 0; i < lado; ++i)
        {
            Instantiate(objeto, posicion + offset, rotacionZ, transform);
            posicion += desplazamientoZ;
        }
        posicion -= (0.25f * desplazamientoZ) + (0.25f * desplazamientoX);
        
        for (int i = 0; i < lado; ++i)
        {
            Instantiate(objeto, posicion + offset, rotacionX, transform);
            posicion -= desplazamientoX;
        }
        posicion += (0.25f * desplazamientoX) - (0.25f * desplazamientoZ);
        
        for (int i = 0; i < lado; ++i)
        {
            Instantiate(objeto, posicion + offset, rotacionZ, transform);
            posicion -= desplazamientoZ;
        }
        posicion += (0.25f * desplazamientoZ) + (0.75f * desplazamientoX);
    }
}
