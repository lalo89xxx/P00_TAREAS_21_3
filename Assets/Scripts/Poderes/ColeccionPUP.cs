using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColeccionPUP : MonoBehaviour
{
    POWERUP monedasSuma; 
    
    // Start is called before the first frame update
    void Start()
    {
        monedasSuma = FindObjectOfType<POWERUP>();
    }

    

    void OnCollisionEnter(Collision otraMonedas)
    {
        if (otraMonedas.gameObject.tag == "Player")
        {
            monedasSuma.Up += 200;

            Destroy(this.gameObject);
        }
    }

}
