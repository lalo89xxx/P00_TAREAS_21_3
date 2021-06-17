using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class ConstructorJugador
{
  public int JugadorID;

  public string Nombre;

  public float Vida;

  public float Velocidad;

  private Transform PosicionActual;

  private int daño;


  public ConstructorJugador(int id, string N, float Vida, float Vel)
  {
        this.JugadorID = id;
        this.Nombre = N;
        this.Vida = Vida;
        this.Velocidad = Vel;
      

      
      
  }


}
