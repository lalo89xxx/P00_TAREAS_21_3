using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/

public class Item : MonoBehaviour
{

    public int ItemID;

    public string Nombre;

    BaseItem BDItem;

    /*En esta parte se manda a llamar al script base item, es donde se declaran las variables que 
    se van a mandar a llamar en la plataforma Unity*/

    private void Start() 
  {
   
     BDItem = GameObject.FindObjectOfType<BaseItem>();

     cargarDatos(ItemID);



   
  }
  
  //Estan son las datos visibles que se mostraran en el inspector de Unity
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
