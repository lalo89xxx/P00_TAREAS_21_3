using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/

public class BaseJugadores : MonoBehaviour
{
    public ConstructorJugador[] nuevoJugador;


    // Start is called before the first frame update

    /*Esta es la base de jugadores donde se le asignan los valores, la cantidad de jugadores
    que va tener el juego, nombre, vida, etc. Y se manda a llamar al script Constructor*/

    void Awake()
    {
        nuevoJugador = new ConstructorJugador[2];

        nuevoJugador[0] = new ConstructorJugador(1,"Fredo",1000,50);
        nuevoJugador[1] = new ConstructorJugador(2,"Angelic",1250,25); 
        
        


    
        
    }
}
