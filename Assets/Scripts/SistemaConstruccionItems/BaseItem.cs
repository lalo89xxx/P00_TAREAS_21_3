using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem : MonoBehaviour
{
    public ConstructorItem[] nuevoItem;


    // Start is called before the first frame update
    void Awake()
    {
        nuevoItem = new ConstructorItem[2];

        nuevoItem[0] = new ConstructorItem(1,"Vida +");
        nuevoItem[1] = new ConstructorItem(2,"Vida ++");
        
    
        


    
        
    }
}
