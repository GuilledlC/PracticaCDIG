using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ScriptEstructura : MonoBehaviour
{
    public TowerStats stats;
    
    private int lado1;
    private int lado2;
    private int altura;

    public GameObject Ladrillo;
    public GameObject LadrilloBase;
    public GameObject LadrilloTrigger;

    private Vector3 posicion = new Vector3(0, 0.5F, 0);
    private readonly Vector3 desplazamientoX = new Vector3(2f, 0, 0);
    private readonly Vector3 desplazamientoZ = new Vector3(0, 0, 2f);
    private readonly Vector3 desplazamientoY = new Vector3(0, 1, 0);

    private readonly Quaternion rotacionX = new Quaternion(0, 0, 0, 0);
    private readonly Quaternion rotacionZ = new Quaternion(0.1f, 0, 0.1f, 0);

    // Start is called before the first frame update
    void Start()
    {
        lado1 = stats.getLado();
        lado2 = stats.getAncho();
        altura = stats.getAlturaR();
        stats.totalR = (lado1 * 2 + lado2 * 2) * altura;
        CargarTriggers();
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
        for (int i = 0; i < lado1; ++i)
        {
            Instantiate(objeto, posicion + offset, rotacionX, transform);
            posicion += desplazamientoX;
        }
        posicion -= (0.75f * desplazamientoX) - (0.75f * desplazamientoZ);
        
        for (int i = 0; i < lado2; ++i)
        {
            Instantiate(objeto, posicion + offset, rotacionZ, transform);
            posicion += desplazamientoZ;
        }
        posicion -= (0.75f * desplazamientoZ) + (0.75f * desplazamientoX);
        
        for (int i = 0; i < lado1; ++i)
        {
            Instantiate(objeto, posicion + offset, rotacionX, transform);
            posicion -= desplazamientoX;
        }
        posicion += (0.75f * desplazamientoX) - (0.75f * desplazamientoZ);
        
        for (int i = 0; i < lado2; ++i)
        {
            Instantiate(objeto, posicion + offset, rotacionZ, transform);
            posicion -= desplazamientoZ;
        }
        posicion += (0.75f * desplazamientoZ) + (0.25f * desplazamientoX);
    }
    
    private void CargarPiso1(GameObject objeto, Vector3 offset)
    {
        for (int i = 0; i < lado1; ++i)
        {
            Instantiate(objeto, posicion + offset, rotacionX, transform);
            posicion += desplazamientoX;
        }
        posicion -= (0.25f * desplazamientoX) - (0.25f * desplazamientoZ);
        
        for (int i = 0; i < lado2; ++i)
        {
            Instantiate(objeto, posicion + offset, rotacionZ, transform);
            posicion += desplazamientoZ;
        }
        posicion -= (0.25f * desplazamientoZ) + (0.25f * desplazamientoX);
        
        for (int i = 0; i < lado1; ++i)
        {
            Instantiate(objeto, posicion + offset, rotacionX, transform);
            posicion -= desplazamientoX;
        }
        posicion += (0.25f * desplazamientoX) - (0.25f * desplazamientoZ);
        
        for (int i = 0; i < lado2; ++i)
        {
            Instantiate(objeto, posicion + offset, rotacionZ, transform);
            posicion -= desplazamientoZ;
        }
        posicion += (0.25f * desplazamientoZ) + (0.75f * desplazamientoX);
    }

    private void CargarTriggers()
    {
        GameObject trigger1 = Instantiate(LadrilloTrigger, posicion, rotacionX, transform);
        trigger1.transform.localScale += new Vector3((lado1 - 1.5f) * 2, altura - 1, 0);
        trigger1.transform.position += new Vector3(0, (altura/2) - 0.4f, lado2);
        
        GameObject trigger2 = Instantiate(LadrilloTrigger, posicion, rotacionX, transform);
        trigger2.transform.localScale += new Vector3((lado1 - 1.5f) * 2, altura - 1, 0);
        trigger2.transform.position += new Vector3(0, (altura/2) - 0.4f, -lado2);
        
        GameObject trigger3 = Instantiate(LadrilloTrigger, posicion, rotacionZ, transform);
        trigger3.transform.localScale += new Vector3((lado2 - 1.5f) * 2, altura - 1, 0);
        trigger3.transform.position += new Vector3(lado1, (altura/2) - 0.4f, 0);
        
        GameObject trigger4 = Instantiate(LadrilloTrigger, posicion, rotacionZ, transform);
        trigger4.transform.localScale += new Vector3((lado2 - 1.5f) * 2, altura - 1, 0);
        trigger4.transform.position += new Vector3(-lado1, (altura/2) - 0.4f, 0);
    }
}
