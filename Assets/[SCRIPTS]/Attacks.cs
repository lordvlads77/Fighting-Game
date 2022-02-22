using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
     public GameObject smallfist;
     public GameObject MediumFist;    
    

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            
            smallfist.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            smallfist.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            smallfist.SetActive(true);
            MediumFist.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            smallfist.SetActive(false);
            MediumFist.SetActive(false);
        }
    }

}
