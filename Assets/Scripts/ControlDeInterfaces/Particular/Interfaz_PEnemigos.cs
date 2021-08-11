using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/

public class Interfaz_PEnemigos : MonoBehaviour
{
    [Header ("Interfaces TMPro")]

    public TMP_Text NombreTXTP;
    public TMP_Text VidaTXTP;
    

    Enemigo enemigoData;
    // Start is called before the first frame update

    //Este script es para asignarlo al jugador, crear la variables de tipo texto, esto sirve para 
    //que se puedan imprimir en pantalla y poder controlar lo que uno quiere que se imprima en pantalla
    //como la vida, el nombre, la velocidad, etc. Esto depende de cada quien o del tipo de juego.

    void Start()
    {
        enemigoData = GetComponentInParent<Enemigo>();

        StartCoroutine(AsignarDatos(.1f));
    }

    // Update is called once per frame
    void Update()
    {
       
        if (NombreTXTP != null)
        {
           NombreTXTP.text = enemigoData.Nombre;
            
        }

          if (VidaTXTP != null)
        {
           VidaTXTP.text = enemigoData.Vida.ToString(); 
        }
        
     
        
    }

    //Aqui se asignan y se enuemran los datos que saldran en pantalla.
    IEnumerator AsignarDatos(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        
        if (NombreTXTP != null)
        {
           NombreTXTP.text = enemigoData.Nombre;
           
        }

          if (VidaTXTP != null)
        {
           VidaTXTP.text = enemigoData.Vida.ToString(); 
        }
        
    }
        
        
}
