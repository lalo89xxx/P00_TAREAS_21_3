using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/


public class DestruirBala : MonoBehaviour
{
    //Este script solo sirve para encontrar el objeto bala y destuirlo en un tiempo despues de que 
    //se realize la accion de disparo.
    
    public GameObject Bala;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 2f);
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
