using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TowerStats : ScriptableObject
{
    private int ladoC = 6;
    private int alturaC = 20;
    
    private int lado = 10;
    private int ancho = 5;
    private int alturaR = 10;
    
    private int porcentajeDestruccion = 90;
    
    private bool cuadrado = true;
    
    public int destruidos = 0;
    public int pajarotos = 0;

    public int totalC;
    public int totalR;

    public void LadrilloDestruido()
    {
        destruidos++;
    }

    public void PajarotoLanzado()
    {
        pajarotos++;
        Debug.Log(pajarotos);
    }
    
    public int getLado()
    {
        return this.lado;
    }
    
    public void setLado(int lado)
    {
        this.lado = lado;
    }
    
    public int getLadoC()
    {
        return this.ladoC;
    }
    
    public void setLadoC(int ladoC)
    {
        this.ladoC = ladoC;
    }
    
    
    public int getAncho()
    {
        return this.ancho;
    }
    
    public void setAncho(int ancho)
    {
        this.ancho = ancho;
    }
    
    
    public int getAlturaC()
    {
        return this.alturaC;
    }

    public void setAlturaC(int alturaC)
    {
        this.alturaC = alturaC;
    }
    
    public int getAlturaR()
    {
        return this.alturaR;
    }

    public void setAlturaR(int alturaR)
    {
        this.alturaR = alturaR;
    }
    
    
    public int getPorcentajeDestuccion()
    {
        return this.porcentajeDestruccion;
    }
    
    public void setPorcentajeDestuccion(int porcentajeDestruccion)
    {
        this.porcentajeDestruccion = porcentajeDestruccion;
    }
    
    
    public bool getCuadrado()
    {
        return this.cuadrado;
    }
    
    public void setCuadrado(bool cuadrado)
    {
        this.cuadrado = cuadrado;
    }

    public string mostrarEstadisticas()
    {
        return "RECTANGULO: lado: " + this.lado + ", ancho: " + this.ancho + ", altura: " + this.alturaR
               + "        CUADRADO: lado: " + this.ladoC + ", altura: " + this.alturaC
               + ", destruccion: " + this.porcentajeDestruccion;
    }
}
