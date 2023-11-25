using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieces : MonoBehaviour
{

    public GameObject coin;
    public int nombrePieces;
    public int destroyedBullet;
    

    //public GameObject sol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Sol") //si la pièce tombe sur le sol, elle est détruite 
        {
            Destroy(gameObject);//destruction de la pièce 
            Debug.Log("détruit");
            
        }

        if (collision.gameObject.tag == "Player") //si la pièce touche le joueur
        {
            Destroy(gameObject);
            Debug.Log("collision avec le player");
        }
    }
}
