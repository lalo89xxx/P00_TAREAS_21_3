using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/

public class Jugador : MonoBehaviour
{
  public int JugadorID;

  public string Nombre;

  public float Vida;

  public float Velocidad;

  BaseJugadores BDjugadores;


  /*En esta parte se manda a llamar al script base jugadores, es donde se declaran las variables que 
  se van a mandar a llamar en la plataforma Unity*/
  private void Start() 
  {
   BDjugadores = GameObject.FindObjectOfType<BaseJugadores>();

   cargarDatos(JugadorID);



   
  }
  
  //Estos son los datos visibles que se mostraran en el inspector de Unity
  void cargarDatos(int id)
    {
        for (int i = 0; i < BDjugadores.nuevoJugador.Length; i++)
        {
            if (BDjugadores.nuevoJugador[i].JugadorID == id)
            {
                this.Nombre = BDjugadores.nuevoJugador[i].Nombre;
                this.Vida = BDjugadores.nuevoJugador[i].Vida;
                this.Velocidad = BDjugadores.nuevoJugador[i].Velocidad;
                
            }

            
        }
    }



}
