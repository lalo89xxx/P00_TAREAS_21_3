using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar_IA_Disparo : MonoBehaviour
{
    
    MOVIA Estados;
    public float Rango_Disparo;
    public LayerMask layerMask;


    // Start is called before the first frame update
    void Start()
    {
        Estados = GetComponentInParent<MOVIA>();
    }

    // Update is called once per frame
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

    void OnDrawGizmos() 
    {
        
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, Rango_Disparo);
        

    }
}
