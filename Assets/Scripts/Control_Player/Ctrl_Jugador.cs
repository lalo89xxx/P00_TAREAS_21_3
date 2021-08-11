using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/

//Este script se creo para crear un contrlador de jugador principal.

public class Ctrl_Jugador : BaseCtrl
{

    public bool StandAtaque;

    int indice;

    public GameObject Pistola;

    public GameObject Pistola2;

    public GameObject Pistola3;

    


    // Start is called before the first frame update

    /*Estan son la variables game object que se crearon para asignarle un objeto que 
    que simula un arma, esto sirve para que esten desactivadas al iniciar el juego*/
    void Start()
    {
        
     Pistola.SetActive(false);
     Pistola2.SetActive(false);
     Pistola3.SetActive(false);      

        
    }

    // Update is called once per frame
    void Update()
    
    //Se manadan a llamar la variables del script de BaseCtrl ya que son publicas y sean funcionales cuando 
    //este script se le asigne al jugador.
    
    {
        ControlJugador();
        LookAtAim();

        /*Salto();

        Disparo();

        SaltoIdle();

        Correr();*/

        //Estas son las entradas de teclado para iniciar la animaciones con sus respectivas armas 

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
          indice=1;

        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
          indice=2;  
        }

        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
          indice=3;  
        }


        if(Input.GetMouseButtonDown(1))
        {
            indice=0;

            
            
            //if(StandAtaque == false)

            //StandAtaque = true;
            
            //else

            //StandAtaque = false;

          
         


        }

        
        
        StandingAttack(StandAtaque);
        Ataques(indice);

        /*Estos indices se crearon para diferenciar las armas que llevara cada animacion
        de acuerdo a las entradas de teclado*/

        switch(indice)
         {
             case 1:
             Pistola.SetActive(true);
             break;

             case 2:
             Pistola.SetActive(false);
             break;

             case 3:
             Pistola.SetActive(false);
             break;

             default:
             Pistola.SetActive(false);
             break;

         }

         switch(indice)
         {
             case 1:
             Pistola2.SetActive(false);
             break;

             case 2:
             Pistola2.SetActive(true);
             break;

             case 3:
             Pistola2.SetActive(false);
             break;

             default:
             Pistola2.SetActive(false);
             break;

         }

          switch(indice)
         {
             case 1:
             Pistola3.SetActive(false);
             break;

             case 2:
             Pistola3.SetActive(false);
             break;

             case 3:
             Pistola3.SetActive(true);
             break;

             default:
             Pistola3.SetActive(false);
             break;

         }
        
            


        

    }

    /*Estas variables se usan para asignar el movimeinto del jugador,
    se heredan del script BaseCtrl*/

    protected override void ControlJugador()
    {
        float vertical = Input.GetAxis("Vertical");

        float horizontal = Input.GetAxis("Horizontal");

        direction = new Vector3(horizontal ,0 ,vertical);

        


        base.ControlJugador();


    }
}
