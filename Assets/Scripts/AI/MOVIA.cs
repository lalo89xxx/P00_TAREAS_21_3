using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EstadosAI
{
    Idle,
    Persecucion,
    AtaqueDistanacia
}

public class MOVIA : MonoBehaviour
{
    public EstadosAI estadoActual;
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
      

        transform.LookAt(Target);
        
        switch(estadoActual)
      {
          case EstadosAI.Idle:
          PlayerAnimation("Idle");
          
          break;

          case EstadosAI.Persecucion:
          PlayerAnimation("Fast Run");
          Move(direccion);
          break;

          case EstadosAI.AtaqueDistanacia:
          PlayerAnimation("Shooting");
          
          break;

          default:
          break;


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
