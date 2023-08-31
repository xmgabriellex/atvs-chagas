using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wasd : MonoBehaviour
{
   
    
    void Update()
    {
        //W
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Tecla W pressionada");

        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("Tecla W solta");
        }
        //A
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Tecla A pressionada");

        }
        else if(Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("Tecla A solta");
        }
        //S
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Tecla S pressionada");

        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            Debug.Log("Tecla S solta");
        }
        //D
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Tecla D pressionada");

        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("Tecla D solta ");
        }
    }
}
