using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar_IA : MonoBehaviour
{
    MOVIA Estados;
    public float Rango_Persecucion;
    public LayerMask layerMask;


    // Start is called before the first frame update
    void Start()
    {
        Estados = GetComponentInParent<MOVIA>();
    }

    // Update is called once per frame
    void Update()
    {
        bool RadarBool = Physics.CheckSphere(transform.position, Rango_Persecucion, layerMask);

        if(RadarBool == true)
        {
            
            Estados.estadoActual = EstadosAI.Persecucion;

              

        }
        else
        {
            Estados.estadoActual = EstadosAI.Idle; 
            
        }

        
        
    }

    void OnDrawGizmos() 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Rango_Persecucion);

        

    }
}
