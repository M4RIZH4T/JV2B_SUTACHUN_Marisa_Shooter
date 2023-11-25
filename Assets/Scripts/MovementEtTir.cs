using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEtTir : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bigBullet;
    public Transform parent;
    public Transform limitL;
    public Transform limitR;

    public float speed = 0.1f; //vitesse du d�placement 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)) //le joueur se d�place vers la gauche quand il appuie sur la fl�che gauche 
        {
            transform.position += Vector3.left*speed;
        }
        if (Input.GetKey(KeyCode.RightArrow)) //le joueur se d�place vers la droite quand il appluie sur la fl�che droite 
        {
            transform.position += Vector3.right*speed;
        }
        

        //tirer une grosse balle 
        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            Instantiate(bigBullet, parent.position, parent.rotation);
        }

        //faire revenir le joueur quand il atteint la limite droite, il va appara�tre � la limite gauche
        if (transform.position.x < limitL.position.x)
        {
            transform.position = new Vector3(limitR.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitR.position.x)
        {
            transform.position = new Vector3(limitL.position.x, transform.position.y, transform.position.z);
        }
    }
}
