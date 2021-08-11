using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/

public class Disparo : MonoBehaviour
{
    public Transform CañonArma;

    public Rigidbody Bala;

    public int FuerzaBala;

    //Este script se creo para instnaciar un objeto llamado bala y crear la ilusion que nuestro jugador
    //esta disparando, se crean variables para que se les asigne objetos y valores dentro del inspector 
    //de Unity.

    public void Disparar()
    { 
        Rigidbody rbPos = Instantiate(Bala) as Rigidbody;
        rbPos.transform.position = CañonArma.position;
        rbPos.AddForce(CañonArma.forward*FuerzaBala);
        

    }
}
