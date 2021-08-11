using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/

//Aqui se declaran las animacion que se usaran para la IA, creando una 
//maquina de estados.

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

    //Aqui se manada a llamar al animator y se declara el estado inicial de IA.
    void Start()
    {
        AnimEnemigo = GetComponent <Animator>();
        estadoActual = EstadosAI.Idle;
    }

    // Update is called once per frame
    void Update()
    {
        //Formula:
        //Direccion = punto de llagada - punto de origen;
        
        
        //Aqui se declara la posicion, el objetivo, y los estados del IA.
        Vector3 direccion = Target.position - transform.position;
      

        transform.LookAt(Target);
        
        //Se crea un indice para que entren en accion las animacones dependiendo
        //del caso que se presente.

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

    //Aqui se declara el movimiento, la direccion, la velocidad, el tiempo y el espacio donde se
    //va mover el IA.

    private void Move(Vector3 direccion)
    {
        
        
     this.transform.Translate(direccion.normalized * Velocidad * Time.deltaTime,Space.World);
             
        

    }

    //En esta parte sirve para activar la animacion que va entrar en accion dependiendo el caso, 
    //por eso se creo un indice.

     private void ActivarAnimacionBool(string NombreAnimacion, bool Valor)
    {

       AnimEnemigo.SetBool(NombreAnimacion, Valor);
    }

    private void PlayerAnimation(string NombreClip)
    {
        AnimEnemigo.Play(NombreClip);
    }
}
