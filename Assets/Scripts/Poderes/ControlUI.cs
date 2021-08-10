using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlUI : MonoBehaviour
{
    public TMP_Text[] interfaceTXT;
    public GameObject Player;
    public POWERUP TMP_TextPowerUP;
    public FRENESI TMP_TextFrenesi;
    
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        TMP_TextPowerUP = GetComponent<POWERUP>();
        TMP_TextFrenesi = GetComponent<FRENESI>();
        interfaceTXT[0].text = "PowerUP: " + TMP_TextPowerUP.Up.ToString();
        interfaceTXT[1].text = "Frenesi: " + TMP_TextFrenesi.Fr.ToString();

        

    }

    // Update is called once per frame
    void Update()
    {
      
        interfaceTXT[0].text = "PowerUP: " + TMP_TextPowerUP.Up.ToString();
        interfaceTXT[1].text = "Frenesi: " + TMP_TextFrenesi.Fr.ToString();

    }
}
