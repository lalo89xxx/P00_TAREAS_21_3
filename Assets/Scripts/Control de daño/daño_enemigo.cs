using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/

public class daño_enemigo : MonoBehaviour
{
    Enemigo enemigoData;

    // Start is called before the first frame update

    //Este script servira para mandar a llamar al enemigo y poder declarar un colision y cree un cambio en
    //este caso negativo que va a restar la vida del enemigo.

    void Start()
    {
        enemigoData = GetComponentInParent<Enemigo>();
    }

    //Esta es la accion que genera un cambio en la variable vida del enemigo, tambien se va declarar
    //una variable publica para poder modificarla desde el inspector y no tener que estar entrando al codigo 
    //para hacerle un cambio.

    public void Damage()
    {
        
        enemigoData.Vida -= 5;

 
    }
    
    public void Damage(float Daño)
    {
        
        enemigoData.Vida -= Daño;

 
    }
}
