using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseJugadores : MonoBehaviour
{
    public ConstructorJugador[] nuevoJugador;


    // Start is called before the first frame update
    void Awake()
    {
        nuevoJugador = new ConstructorJugador[2];

        nuevoJugador[0] = new ConstructorJugador(1,"Fredo",40,15);
        nuevoJugador[1] = new ConstructorJugador(2,"Angelic",30,25); 
        
        


    
        
    }
}
