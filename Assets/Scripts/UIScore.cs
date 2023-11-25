using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class UIScore : MonoBehaviour
{
    public TextMeshProUGUI monUI;
    public int destroyedBullet; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        monUI.text = "HAPPY CATS : "; //afficher le texte voulu  
            //+ destroyedBullet;
    }
}
