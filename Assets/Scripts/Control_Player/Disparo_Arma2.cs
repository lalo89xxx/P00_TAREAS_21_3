using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_Arma2 : MonoBehaviour
{
     public Transform CañonArma;

    public Rigidbody Bala2;

    public int FuerzaBala;

    public void Disparo2()
    { 
        Rigidbody rbPos = Instantiate(Bala2) as Rigidbody;
        rbPos.transform.position = CañonArma.position;
        rbPos.AddForce(CañonArma.forward*FuerzaBala);
    }

}
