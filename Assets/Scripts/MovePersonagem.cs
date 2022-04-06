// bibliotecas/libs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// aqui começa o nosso código
public class MovePersonagem : MonoBehaviour
{
    RBManager manager;

    void Start()
    {
        Inicializar();
    }

    void Update()
    {
        manager.entrada.RegistrarInputs();
    }

    void FixedUpdate() 
    {
        manager.Mover();
        manager.TentarPular();
    }

    private void Inicializar()
    {
        manager = new RBManager( GetComponent<Rigidbody>() );
    }


}
