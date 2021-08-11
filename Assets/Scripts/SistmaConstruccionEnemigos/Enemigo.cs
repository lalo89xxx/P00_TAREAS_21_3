using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/

public class Enemigo : MonoBehaviour
{
    public int EnemigoID;

    public string Nombre;

    public float Vida;

     public float Velocidad;

     BaseEnemigo BDEnemigos;
    
    
    // Start is called before the first frame update
    
    /*En esta parte se manda a llamar al script base enemigos, es donde se declaran las variables que 
    se van a mandar a llamar en la plataforma Unity*/
   private void Start() 
  {
   
     BDEnemigos = GameObject.FindObjectOfType<BaseEnemigo>();

     cargarDatos(EnemigoID);



   
  }
  
  //Estos son los datos visibles que se mostraran en el inspector de Unity.
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
