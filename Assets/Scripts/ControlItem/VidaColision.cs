using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/


public class VidaColision : MonoBehaviour
{
    
    public float VidaMas;
    
    //En esta parte ya que se genera la varibale de tipo publica y el script que va generar la suma a la vida 
    //del jugador se crea la colision y a crearse la colision se destruye el obajeto con el que se creo la 
    //colison.
     private void OnCollisionEnter(Collision other) 
     
    {
        if (other.gameObject.tag == "Player")
        {

            other.gameObject.GetComponent<VIdaPlus_Jugador>().Life(VidaMas);
            Destroy(this.gameObject);
            
           

        


        }
    }

    
}
