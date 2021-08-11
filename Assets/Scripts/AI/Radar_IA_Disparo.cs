using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/

public class Radar_IA_Disparo : MonoBehaviour
{
    
    MOVIA Estados;
    public float Rango_Disparo;
    public LayerMask layerMask;


    // Start is called before the first frame update

    //Aqui se manda a llamar a la maquina de estados.
    void Start()
    {
        Estados = GetComponentInParent<MOVIA>();
    }

    // Update is called once per frame

    //Se crea un radar para crear una reaccion de la IA cuando el jugador entre
    //en la zona de radar.
    void Update()
    {
       
       bool RadarDisparo = Physics.CheckSphere(transform.position, Rango_Disparo, layerMask);
        
        if(RadarDisparo == true)
        {
            Estados.estadoActual = EstadosAI.AtaqueDistanacia;

              

        }
        else
        {
            Estados.estadoActual = EstadosAI.Idle; 
        }
    }

    //Esta parte sirve para crear la zona de radar en basde a gizmos y darle un color 
    //para diferenciarlos si es que se usa mas de un radar.

    void OnDrawGizmos() 
    {
        
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, Rango_Disparo);
        

    }
}
