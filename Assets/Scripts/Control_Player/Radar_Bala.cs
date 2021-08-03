using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar_Bala : MonoBehaviour
{
    public Transform ArmaPosicion;

    public LayerMask layerMask;

    public float RangoAtaque;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool RadarBool = Physics.CheckSphere(ArmaPosicion.position, RangoAtaque, layerMask);

        if(RadarBool == true)
        {   

            GameObject enemigo = GameObject.FindWithTag("Enemy");

            Destroy(enemigo);   
            
            Debug.Log("Me heriste");

              

        }
        
        else
        {
            Debug.Log("No me heriste");
        }


    }

    
     void OnDrawGizmos() 
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireSphere(ArmaPosicion.position, RangoAtaque);
        

    }
}


