using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
     public GameObject smallfist;
     public GameObject MediumFist;
     public GameObject BigFist;
    

   
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

        if (Input.GetKeyDown(KeyCode.Q))
        {
            smallfist.SetActive(true);
            MediumFist.SetActive(true);
            BigFist.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            smallfist.SetActive(false);
            MediumFist.SetActive(false);
            BigFist.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            smallfist.SetActive(true);
            MediumFist.SetActive(true);
            BigFist.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            smallfist.SetActive(false);
            MediumFist.SetActive(false);
            BigFist.SetActive(false);
        }
    }

}
