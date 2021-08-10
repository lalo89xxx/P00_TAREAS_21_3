using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColeccionFrensi : MonoBehaviour
{
    FRENESI monedasSuma;

    public int Fr;
    
    // Start is called before the first frame update
    void Start()
    {
        monedasSuma = FindObjectOfType<FRENESI>();
    }

    

    void OnCollisionEnter(Collision otraMonedas)
    {
        if (otraMonedas.gameObject.tag == "Player")
        {
            monedasSuma.Fr += Fr;;

            Destroy(this.gameObject);
        }
    }
}
