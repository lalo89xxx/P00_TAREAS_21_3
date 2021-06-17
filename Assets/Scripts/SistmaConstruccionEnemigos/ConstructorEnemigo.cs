using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class ConstructorEnemigo
{
  public int EnemigoID;

  public string Nombre;

  public float Vida;

  public float Velocidad;

  private Transform PosicionActual;

  private int daño;


  public ConstructorEnemigo(int id, string N, float Vida, float Vel)
  {
        this.EnemigoID = id;
        this.Nombre = N;
        this.Vida = Vida;
        this.Velocidad = Vel;
      

      
      
  }
}
