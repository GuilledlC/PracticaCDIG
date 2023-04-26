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
    private bool rectangulo;

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
    
    
    public bool getRectangulo()
    {
        return this.rectangulo;
    }
    
    public void setRectangulo(bool rectangulo)
    {
        this.rectangulo = rectangulo;
    }

    public string mostrarEstadisticas()
    {
        return "lado: " + this.lado + ", ancho: " + this.ancho + ", altura: " + this.altura +
               ", porcentaje: " + this.porcentajeDestruccion + ", esRectangulo: " + this.rectangulo;
    }
}
