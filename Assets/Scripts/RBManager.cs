using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RBManager 
{
    public Rigidbody meuRb;
    public float velocidadeMovimento;
    public float forcaPulo;

    public InputReader entrada;

    public RBManager(Rigidbody _rb)
    {
        meuRb = _rb;
        entrada = new InputReader();
    }

    public void Mover()
    {
        Vector3 dir = new Vector3(entrada.inputVector.x, 0, entrada.inputVector.y);
        meuRb.AddForce(dir * velocidadeMovimento, ForceMode.Force);
    }

    public void TentarPular()
    {
        if(Input.GetAxis("Jump") > 0f)
        {
            Vector3 dirPulo = Vector3.up;
            meuRb.AddForce(dirPulo * forcaPulo, ForceMode.Impulse);
        }
    }
}
