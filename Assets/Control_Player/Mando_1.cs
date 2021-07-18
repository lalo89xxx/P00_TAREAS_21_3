using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mando_1 : MonoBehaviour
{
    [SerializeField]
    private float VelocidadMov;
    
    [SerializeField]
    private float VelocidadRot;

    [SerializeField]
    private float VelocidadRotHorizontal;

    [SerializeField]
    private float VelocidadRotVertical;

    Animator AnimacionPL;

    
    void Awake() 
    {
        AnimacionPL = GetComponent<Animator>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

   
    {
        float h_rotacion = Input.GetAxis("Mouse X");
        float v_rotacion = Input.GetAxis("Mouse Y");
        
        ControlJugador();
        LookAtAim(h_rotacion,v_rotacion);
        Salto();
        Disparo();
        SaltoIdle();
        
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

    
    private void ControlJugador()
    {
        float vertical = Input.GetAxis("Vertical");// Resgistra el hardware 

        Vector3 direction = new Vector3 (0, 0, vertical);// Convierte en electricidad  

        direction *= Time.deltaTime * VelocidadMov;

        bool directionForward = direction.z != 0 ? true : false ;

        this.transform.Translate(direction);

        AnimacionPL.SetBool("Walk",directionForward);
    }


 
    private void Salto()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            AnimacionPL.SetTrigger("JUMP");
        }

    }
    private void Disparo()
    {

        if(Input.GetMouseButtonDown(0))
        {
            AnimacionPL.SetTrigger("SHOOT");
        }

    }

    private void SaltoIdle()
    {

        if(Input.GetKeyDown(KeyCode.R))
        {
            AnimacionPL.SetTrigger("JUMP2");
        }

    }
}
