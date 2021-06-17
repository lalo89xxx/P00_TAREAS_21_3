using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VIdaPlus_Jugador : MonoBehaviour
{
    Jugador playerData;

    // Start is called before the first frame update
    void Start()
    {
        playerData = GetComponentInParent<Jugador>();
    }

    
    public void Life()
    {
        
        playerData.Vida += 5;

 
    }
    
    public void Life(float VidaMas)
    {
        
        playerData.Vida += VidaMas;

 
    }

}
