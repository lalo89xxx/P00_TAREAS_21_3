using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class ConstructorItem
{
   public int EnemigoID;

   public string Nombre;

   private Transform PosicionActual;

   private int VidaMas;

   public ConstructorItem(int id, string N)
  {
        this.EnemigoID = id;
        this.Nombre = N;
        
        
      

      
      
  }

}
