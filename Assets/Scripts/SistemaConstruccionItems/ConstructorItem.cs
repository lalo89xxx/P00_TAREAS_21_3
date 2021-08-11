using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/


[System.Serializable]
public class ConstructorItem
{
   public int ItemID;

   public string Nombre;

   private Transform PosicionActual;

   private int VidaMas;

   /*Aqui se crean los datos del item, como nombre, vida, etc, creando un cosntructor para despues mandralos 
  llamar y asignarlos*/

   public ConstructorItem(int id, string N)
  {
        this.ItemID = id;
        this.Nombre = N;
        
        
      

      
      
  }

}
