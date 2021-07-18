using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrl_Jugador : BaseCtrl
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ControlJugador();

        Salto();

        Disparo();

        SaltoIdle();

        Correr();
    }

    protected override void ControlJugador()
    {
        float vertical = Input.GetAxis("Vertical");

        float horizontal = Input.GetAxis("Horizontal");

        direction = new Vector3(horizontal ,0 ,vertical);

        


        base.ControlJugador();


    }
}
