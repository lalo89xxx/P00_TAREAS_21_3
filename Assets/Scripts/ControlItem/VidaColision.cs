using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaColision : MonoBehaviour
{
    
    public float VidaMas;
    
     private void OnCollisionEnter(Collision other) 
     
    {
        if (other.gameObject.tag == "Player")
        {

            other.gameObject.GetComponent<VIdaPlus_Jugador>().Life(VidaMas);
            Destroy(this.gameObject);
            
           

        


        }
    }

    
}
