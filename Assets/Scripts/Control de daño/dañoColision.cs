using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dañoColision : MonoBehaviour
{
    public float Daño;
    
     private void OnCollisionEnter(Collision other) 
     
    {
        if (other.gameObject.tag == "Player")
        {

            other.gameObject.GetComponent<daño_jugador>().Damage(Daño);


        }
    }
}
