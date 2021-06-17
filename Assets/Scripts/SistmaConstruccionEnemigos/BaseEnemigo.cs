using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemigo : MonoBehaviour
{
    public ConstructorEnemigo[] nuevoEnemigo;


    // Start is called before the first frame update
    void Awake()
    {
        nuevoEnemigo = new ConstructorEnemigo[4];

        nuevoEnemigo[0] = new ConstructorEnemigo(1,"Mister X",200,40);
        nuevoEnemigo[1] = new ConstructorEnemigo(2,"Pachito",150,35);
        nuevoEnemigo[2] = new ConstructorEnemigo(3,"Mr Pop",100,30);
        nuevoEnemigo[3] = new ConstructorEnemigo(4,"Ciruela",50,25);  
        
        


    
        
    }
}
