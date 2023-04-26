using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TowerStats : ScriptableObject
{
    private int lado;
    private int ancho;
    private int altura;
    private int porcentajeDestruccion;

    public int getLado()
    {
        return this.lado;
    }
    
    public void setLado(int lado)
    {
        this.lado = lado;
    }
    
    
    public int getAncho()
    {
        return this.ancho;
    }
    
    public void setAncho(int ancho)
    {
        this.ancho = ancho;
    }
    
    
    public int getAltura()
    {
        return this.altura;
    }

    public void setAltura(int altura)
    {
        this.altura = altura;
    }
    
    
    public int getPorcentajeDestuccion()
    {
        return this.porcentajeDestruccion;
    }
    
    public void setPorcentajeDestuccion(int porcentajeDestruccion)
    {
        this.porcentajeDestruccion = porcentajeDestruccion;
    }
}
