using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class ConstructorItem
{
   public int ItemID;

   public string Nombre;

   private Transform PosicionActual;

   private int VidaMas;

   public ConstructorItem(int id, string N)
  {
        this.ItemID = id;
        this.Nombre = N;
        
        
      

      
      
  }

}
