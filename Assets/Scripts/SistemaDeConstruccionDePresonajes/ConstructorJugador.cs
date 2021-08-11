using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/


[System.Serializable]
public class ConstructorJugador
{
  public int JugadorID;

  public string Nombre;

  public float Vida;

  public float Velocidad;


  private Transform PosicionActual;

  private int daño;

  /*Aqui se crean los datos del jugador, como nombre, vida, etc, creando un cosntructor para despues mandralos 
  llamar y asignarlos*/
  public ConstructorJugador(int id, string N, float Vida, float Vel)
  {
        this.JugadorID = id;
        this.Nombre = N;
        this.Vida = Vida;
        this.Velocidad = Vel;
        
      

      
      
  }


}
