using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/

public class Interfaz_Particular : MonoBehaviour
{

    [Header ("Interfaces Basicas")]
    public Text NombreTXT;
    public Text VidaTXT;

    [Header ("Interfaces TMPro")]

    public TMP_Text NombreTXTP;
    public TMP_Text VidaTXTP;

    Jugador playerData;


    // Start is called before the first frame update

    //Este script es para asignarlo al jugador, crear la variables de tipo texto, esto sirve para 
    //que se puedan imprimir en pantalla y poder controlar lo que uno quiere que se imprima en pantalla
    //como la vida, el nombre, la velocidad, etc. Esto depende de cada quien o del tipo de juego.
    void Start()
    {
        playerData = GetComponentInParent<Jugador>();

        StartCoroutine(AsignarDatos(.1f));
    }

    // Update is called once per frame
    void Update()
    {

         if (NombreTXT != null)
        {
           NombreTXT.text = playerData.Nombre; 
        }
        
        if (VidaTXT != null)
        {
           VidaTXT.text = playerData.Vida.ToString(); 
        }

        if (NombreTXTP != null)
        {
           NombreTXTP.text = playerData.Nombre; 
        }
        
        if (VidaTXTP != null)
        {
           VidaTXTP.text = playerData.Vida.ToString(); 
        }
        
    }

    //Aqui se asignan y se enuemran los datos que saldran en pantalla.

    IEnumerator AsignarDatos(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        if (NombreTXT != null)
        {
           NombreTXT.text = playerData.Nombre; 
        }
        
        if (VidaTXT != null)
        {
           VidaTXT.text = playerData.Vida.ToString(); 
        }
        
        if (NombreTXTP != null)
        {
           NombreTXTP.text = playerData.Nombre; 
        }
        
        if (VidaTXTP != null)
        {
           VidaTXTP.text = playerData.Vida.ToString(); 
        }
        
        
        
        
       


    
    }
}
