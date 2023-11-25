using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementEnnemis2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform groupeEnnemisDeux;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        groupeEnnemisDeux.position += new Vector3(0.0008f, -0.0008f, 0); //faire descendre et aller vers la droite en même temps 
    }
}
