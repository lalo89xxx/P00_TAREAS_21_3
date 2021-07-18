using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCtrl : MonoBehaviour
{
    [SerializeField]
    private float VelocidadMov;
    
    [SerializeField]
    private float VelocidadRot;

    [SerializeField]
    private float VelocidadRotHorizontal;

    [SerializeField]
    private float VelocidadRotVertical;

    protected Vector3  direction = Vector3.zero;

    protected bool directionForward;

    Animator AnimacionPL;

    
    void Awake() 
    {
        AnimacionPL = GetComponent<Animator>();
    }


        

    
    private void LookAtAim()
    {
        float h_rotacion = Input.GetAxis("Mouse X");

        Vector3 rotacion_H = new Vector3(0, h_rotacion, 0);

        rotacion_H *= Time.deltaTime * VelocidadRot;

        this.transform.Rotate(rotacion_H);

        
       
    }

    
    private void LookAtAim(float h, float v)
    {
        float h_rotacion = h;
        float v_rotacion = v;

        Vector3 rotacion = new Vector3(v_rotacion, h_rotacion, 0);

        rotacion.x *= Time.deltaTime * VelocidadRotHorizontal;
        rotacion.y *= Time.deltaTime * VelocidadRotVertical;
        
        this.transform.localEulerAngles += rotacion;

        

        
       
    }

    
    protected virtual void ControlJugador()
    {
        
        

        this.transform.Translate(direction.normalized * VelocidadMov * Time.deltaTime);

        AnimacionPL.SetFloat("Speed", direction.z);

        AnimacionPL.SetFloat("SpeedLateral", direction.x);

        
    }


 
    protected void Salto()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            AnimacionPL.SetTrigger("JUMP");
        }

    }
    protected void Disparo()
    {

        if(Input.GetMouseButtonDown(0))
        {
            AnimacionPL.SetTrigger("SHOOT");
        }

    }

    protected void SaltoIdle()
    {

        if(Input.GetKeyDown(KeyCode.J))
        {
            AnimacionPL.SetTrigger("JUMP2");
        }

    }

     protected void Correr()
    {

        if(Input.GetKeyDown(KeyCode.R))
        {
            AnimacionPL.SetTrigger("RUN");
        }

    }

    protected bool DirectionForward(float d)
    {
        bool directionForward = d != 0 ? true : false ;
        return directionForward;


    }
}
