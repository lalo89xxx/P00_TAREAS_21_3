using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVIA : MonoBehaviour
{
    public Transform Target;

    public float Velocidad;

    public Animator AnimEnemigo;

    public float DistanciaExacta;

    


    // Start is called before the first frame update
    void Start()
    {
        AnimEnemigo = GetComponent <Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Formula:
        //Direccion = punto de llagada - punto de origen;
        Vector3 direccion = Target.position - transform.position;
        Debug.Log(direccion.magnitude);

        transform.LookAt(Target);

        if(direccion.magnitude > DistanciaExacta)
        {
             Move(direccion);
             ActivarAnimacionBool("RUN",true);
        }

       else if(direccion.magnitude <= DistanciaExacta)
       {
           PlayerAnimation("Quad Punch");

       }
       
       else
       {
            PlayerAnimation("Idle"); 
            ActivarAnimacionBool("RUN",false);

       }
       


    }

    private void Move(Vector3 direccion)
    {
        
        
     this.transform.Translate(direccion.normalized * Velocidad * Time.deltaTime,Space.World);
             
        

    }

     private void ActivarAnimacionBool(string NombreAnimacion, bool Valor)
    {

        AnimEnemigo.SetBool(NombreAnimacion, Valor);
    }

    private void PlayerAnimation(string NombreClip)
    {
        AnimEnemigo.Play(NombreClip);
    }
}
