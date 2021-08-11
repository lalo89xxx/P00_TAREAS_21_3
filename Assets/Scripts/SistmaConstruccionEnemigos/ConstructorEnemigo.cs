using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/


[System.Serializable]
public class ConstructorEnemigo
{
  public int EnemigoID;

  public string Nombre;

  public float Vida;

  public float Velocidad;

  private Transform PosicionActual;

  private int daño;

   /*Aqui se crean los datos del enemigo, como nombre, vida, etc, creando un cosntructor para despues mandarlos  
  a llamar y asignarlos*/
  public ConstructorEnemigo(int id, string N, float Vida, float Vel)
  {
        this.EnemigoID = id;
        this.Nombre = N;
        this.Vida = Vida;
        this.Velocidad = Vel;
      

      
      
  }
}
