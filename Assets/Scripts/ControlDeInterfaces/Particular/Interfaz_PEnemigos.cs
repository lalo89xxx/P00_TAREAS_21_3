using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interfaz_PEnemigos : MonoBehaviour
{
    [Header ("Interfaces TMPro")]

    public TMP_Text NombreTXTP;
    public TMP_Text VidaTXTP;
    

    Enemigo enemigoData;
    // Start is called before the first frame update
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
