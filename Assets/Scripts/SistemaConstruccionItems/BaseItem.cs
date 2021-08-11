using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/

public class BaseItem : MonoBehaviour
{
    public ConstructorItem[] nuevoItem;


    // Start is called before the first frame update

    /*Esta es la base de items donde se le asignan los valores, la cantidad de items
    que va tener el juego, nombre, vida, etc. Y se manda a llamar al script Constructor*/
    void Awake()
    {
        nuevoItem = new ConstructorItem[2];

        nuevoItem[0] = new ConstructorItem(1,"Vida +");
        nuevoItem[1] = new ConstructorItem(2,"Vida ++");
        
    
        


    
        
    }
}
