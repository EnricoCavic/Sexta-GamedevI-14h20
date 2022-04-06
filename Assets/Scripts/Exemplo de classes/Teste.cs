using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        CartaBase carta1 = new CartaBase();
        CartaBase carta2 = new CartaBase();

        carta1.nome = "João José";
        carta1.efeito = "Destroi todos em campo";
        carta1.vida = 20;
        carta1.ataque = 23754283;
        carta1.defesa = 71;
        carta1.magia = 2;
        carta1.custo = 12;

        carta2.nome = "Ana Maria";
        carta2.efeito = "Sempre tem uma receita pré-preparada";
        carta2.vida = 4;
        carta2.ataque = int.MaxValue;
        carta2.defesa = 2;
        carta2.magia = int.MaxValue;
        carta2.custo = 87423;
    }

}
