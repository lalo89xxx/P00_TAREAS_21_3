using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_Arma1 : MonoBehaviour
{
    public Transform CañonArma;

    public Rigidbody Bala1;

    public int FuerzaBala;

    public void Disparo1()
    { 
        Rigidbody rbPos = Instantiate(Bala1) as Rigidbody;
        rbPos.transform.position = CañonArma.position;
        rbPos.AddForce(CañonArma.forward*FuerzaBala);

        
       
        

    }
}
