using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColeccionPUP : MonoBehaviour
{
    POWERUP monedasSuma;

    public int Up;
    
    // Start is called before the first frame update
    void Start()
    {
        monedasSuma = FindObjectOfType<POWERUP>();
    }

    

    void OnCollisionEnter(Collision otraMonedas)
    {
        if (otraMonedas.gameObject.tag == "Player")
        {
            monedasSuma.Up += Up;

            Destroy(this.gameObject);
        }
    }

}
