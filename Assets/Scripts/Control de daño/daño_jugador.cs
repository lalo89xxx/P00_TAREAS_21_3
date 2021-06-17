using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daño_jugador : MonoBehaviour
{
    Jugador playerData;

    // Start is called before the first frame update
    void Start()
    {
        playerData = GetComponentInParent<Jugador>();
    }

    
    public void Damage()
    {
        
        playerData.Vida -= 5;

 
    }
    
    public void Damage(float Daño)
    {
        
        playerData.Vida -= Daño;

 
    }



}
