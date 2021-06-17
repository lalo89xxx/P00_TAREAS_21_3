using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int EnemigoID;

    public string Nombre;

    public float Vida;

     public float Velocidad;

     BaseEnemigo BDEnemigos;
    
    
    // Start is called before the first frame update
  
   private void Start() 
  {
   
     BDEnemigos = GameObject.FindObjectOfType<BaseEnemigo>();

     cargarDatos(EnemigoID);



   
  }
  

  void cargarDatos(int id)
    {
        for (int i = 0; i < BDEnemigos.nuevoEnemigo.Length; i++)
        {
            if (BDEnemigos.nuevoEnemigo[i].EnemigoID == id)
            {
                this.Nombre = BDEnemigos.nuevoEnemigo[i].Nombre;
                this.Vida = BDEnemigos.nuevoEnemigo[i].Vida;
                this.Velocidad = BDEnemigos.nuevoEnemigo[i].Velocidad; 
            }

            
        }
    }

}
