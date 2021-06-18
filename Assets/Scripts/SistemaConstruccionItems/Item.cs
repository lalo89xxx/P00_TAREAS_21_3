using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public int ItemID;

    public string Nombre;

    BaseItem BDItem;

    private void Start() 
  {
   
     BDItem = GameObject.FindObjectOfType<BaseItem>();

     cargarDatos(ItemID);



   
  }
  

  void cargarDatos(int id)
    {
        for (int i = 0; i < BDItem.nuevoItem.Length; i++)
        {
            if (BDItem.nuevoItem[i].ItemID == id)
            {
                this.Nombre = BDItem.nuevoItem[i].Nombre;
                
                
            }

            
        }
    }
    
    
}
