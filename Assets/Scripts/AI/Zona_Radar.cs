using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zona_Radar : MonoBehaviour
{
   public MOVIA Enemigo; 
   
   private void OnTriggerEnter(Collider other) 
   {
       if(other.CompareTag("Player"))
       {
          Enemigo.estadoActual = EstadosAI.AtaqueDistanacia;
       }
   }

   private void OnTriggerExit(Collider other) 
   {
        if(other.CompareTag("Player"))
       {
          Enemigo.estadoActual = EstadosAI.Persecucion;
       }
       
   }

   
}
