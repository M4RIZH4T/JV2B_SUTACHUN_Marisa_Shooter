using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementEnnemis : MonoBehaviour
{

    public Transform groupeEnnemis;
    public Transform limiteEnnemisBas;
    public Transform limiteEnnemisDroite;
    public Transform limiteEnnemisGauche;
    //public Transform limiteEnnemisHaut;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        groupeEnnemis.position += new Vector3(0, -0.000015f, 0); //faire descendre le groupe d'ennemis vers le bas 

        if(groupeEnnemis.position.y < limiteEnnemisBas.position.y) //quand le groupe d'ennemis atteint cette limite, il va aller vers la droite
        {
            groupeEnnemis.position += new Vector3(0.0002f, 0.000015f, 0); 
        }


        //-------------------------------------------------------------------------------------
        //Ici je voulais faire en sorte que les ennemis passent de la droite vers la gauche comme le player avec des limites mais ça n'a pas marché

        //if(groupeEnnemis.position.x > limiteEnnemisDroite.position.x)
        //{
            //groupeEnnemis.position = new Vector3(limiteEnnemisGauche.position.x, groupeEnnemis.position.y, groupeEnnemis.position.z);
        //}

        //if (groupeEnnemis.position.x < limiteEnnemisDroite.position.x)
        //{
            //groupeEnnemis.position = new Vector3(limiteEnnemisDroite.position.x, groupeEnnemis.position.y, groupeEnnemis.position.z);
        //}


    }
}
