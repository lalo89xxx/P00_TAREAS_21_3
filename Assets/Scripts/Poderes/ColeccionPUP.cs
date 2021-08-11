using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/


public class ColeccionPUP : MonoBehaviour
{
    POWERUP monedasSuma;

    public int Up;
    
    // Start is called before the first frame update

    //Aqui se declara la accion que realizara y se manda a buscar al objeto POWERUP.
    void Start()
    {
        monedasSuma = FindObjectOfType<POWERUP>();
    }

    
    //En esta parte se declara una colision entre el Jugador y el objeto a recolectar.
    void OnCollisionEnter(Collision otraMonedas)
    {
        if (otraMonedas.gameObject.tag == "Player")
        {
            monedasSuma.Up += Up;

            Destroy(this.gameObject);
        }
    }

}
