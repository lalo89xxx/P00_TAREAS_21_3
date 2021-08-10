using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_Arma3 : MonoBehaviour
{
    public Transform CañonArma;

    public Rigidbody Bala3;

    public int FuerzaBala;

    public void Disparo3()
    { 
        Rigidbody rbPos = Instantiate(Bala3) as Rigidbody;
        rbPos.transform.position = CañonArma.position;
        rbPos.AddForce(CañonArma.forward*FuerzaBala);
    }
}
