using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Chrono : MonoBehaviour
{

    public float chrono = 60;
    

    public TextMeshProUGUI monChrono;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        chrono -= Time.deltaTime; //la valeur du chrono moins le temps du jeu 
        monChrono.SetText("TIME : " + chrono); //afficher l'UI temps 

        if (chrono <= 0)

        {
            Application.Quit(); //fermer Unity mais ça marche pas 
        }
    }
}
