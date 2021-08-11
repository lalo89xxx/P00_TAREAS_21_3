using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/

public class VIdaPlus_Jugador : MonoBehaviour
{
    Jugador playerData;

    // Start is called before the first frame update

    //Este script servira para mandar a llamar al jugador y poder declarar un colision y cree un cambio en
    //este caso positivo que va a aumentar la vida del jugador.
    void Start()
    {
        playerData = GetComponentInParent<Jugador>();
    }

    //Esta es la accion que genera un cambio en la variable vida del jugador, tambien se va declarar
    //una variable publica para poder modificarla desde el inspector y no tener que estar entrando al codigo 
    //para hacerle un cambio.
    public void Life()
    {
        
        playerData.Vida += 5;

 
    }
    
    public void Life(float VidaMas)
    {
        
        playerData.Vida += VidaMas;

 
    }

}
