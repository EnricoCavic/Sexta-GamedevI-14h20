using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader 
{
    public Vector2 inputVector;

    public void RegistrarInputs()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");
    }
    
}
