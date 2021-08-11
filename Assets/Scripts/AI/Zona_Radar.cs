using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/

public class Zona_Radar : MonoBehaviour
{
   public MOVIA Enemigo; 
   

   //Se crea una colision con variables triger, en esta parte cuando el jugador
   //crea la colison, la IA activa la animacion correspondinte de acuerdo a las
   //especificaciones de la colision.

   private void OnTriggerEnter(Collider other) 
   {
       if(other.CompareTag("Player"))
       {
          Enemigo.estadoActual = EstadosAI.AtaqueDistanacia;
       }
   }

   //Esta parte se declara la accion que realizara la IA, cuando el jugador salga
   //de la colison y entre la animacion correspondiente.

   private void OnTriggerExit(Collider other) 
   {
        if(other.CompareTag("Player"))
       {
          Enemigo.estadoActual = EstadosAI.Persecucion;
       }
       
   }

   
}
