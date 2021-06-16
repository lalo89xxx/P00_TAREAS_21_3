using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
