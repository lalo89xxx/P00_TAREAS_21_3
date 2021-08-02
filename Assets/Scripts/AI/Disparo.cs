using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Transform CañonArma;

    public Rigidbody Bala;

    public int FuerzaBala;

    public void Disparar()
    { 
        Rigidbody rbPos = Instantiate(Bala) as Rigidbody;
        rbPos.transform.position = CañonArma.position;
        rbPos.AddForce(CañonArma.forward*FuerzaBala);
        

    }
}
