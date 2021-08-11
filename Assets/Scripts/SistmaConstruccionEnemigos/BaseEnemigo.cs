using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/

public class BaseEnemigo : MonoBehaviour
{
    public ConstructorEnemigo[] nuevoEnemigo;


    /*Esta es la base de enemigos donde se le asignan los valores, la cantidad de enemigos
    que va tener el juego, nombre, vida, etc. Y se manda a llamar al script Constructor*/

    // Start is called before the first frame update
    void Awake()
    {
        nuevoEnemigo = new ConstructorEnemigo[4];

        nuevoEnemigo[0] = new ConstructorEnemigo(1,"Mister X",280,40);
        nuevoEnemigo[1] = new ConstructorEnemigo(2,"Pachito",220,35);
        nuevoEnemigo[2] = new ConstructorEnemigo(3,"Mr Pop",250,30);
        nuevoEnemigo[3] = new ConstructorEnemigo(4,"Ciruela",300,25);  
        
        


    
        
    }
}
