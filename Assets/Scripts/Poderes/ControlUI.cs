using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*Nombre: Eduardo Torres Flores.
Profesor: Josue Israel Rivas Diaz.
Asignatura: Programacion Orientada a Objetos*/

public class ControlUI : MonoBehaviour
{
    public TMP_Text[] interfaceTXT;
    public GameObject Player;
    public POWERUP TMP_TextPowerUP;
    public FRENESI TMP_TextFrenesi;
    
    // Start is called before the first frame update

    //Este script se le asignara a un objeto llamado game manager, servira para asignar los datos y el resultado
    //numerico que va generar la colison entre el jugador y el objeto, y poder imprirmirlos en pantalla, para que
    //esto funcione se tienen que mandar a llamar a los scripts FRENESI Y POWERUP, y asignarles variables de tipo
    //texto.
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        TMP_TextPowerUP = GetComponent<POWERUP>();
        TMP_TextFrenesi = GetComponent<FRENESI>();
        interfaceTXT[0].text = "PowerUP: " + TMP_TextPowerUP.Up.ToString();
        interfaceTXT[1].text = "Frenesi: " + TMP_TextFrenesi.Fr.ToString();

        

    }

    // Update is called once per frame

    //Aqui se duplican las variables de tipo texto ya que estas son las que sufriran el cambio y mostraran
    //el dato que resulta de la colison y lo imprimira en pantalla. 
    void Update()
    {
      
        interfaceTXT[0].text = "PowerUP: " + TMP_TextPowerUP.Up.ToString();
        interfaceTXT[1].text = "Frenesi: " + TMP_TextFrenesi.Fr.ToString();

    }
}
