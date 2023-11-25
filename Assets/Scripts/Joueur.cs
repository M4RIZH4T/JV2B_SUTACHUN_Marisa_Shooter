using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Joueur : MonoBehaviour
{ 
    public int destroyedBullet;
    public GameObject bullet;
    public TextMeshProUGUI monUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)) //créer une balle en appuyant sur espace 
        {
            GameObject createdBullet = Instantiate(bullet, transform.position, transform.rotation); //balle créée à la position du player 
            createdBullet.GetComponent<Bullet>().monJoueur = this;

        }

        monUI.text = "HAPPY CATS : " + destroyedBullet; //afficher le nombre 

    }
}
