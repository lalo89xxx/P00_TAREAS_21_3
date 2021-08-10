using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
  public int JugadorID;

  public string Nombre;

  public float Vida;

  public float Velocidad;




  BaseJugadores BDjugadores;

  private void Start() 
  {
   BDjugadores = GameObject.FindObjectOfType<BaseJugadores>();

   cargarDatos(JugadorID);



   
  }

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
