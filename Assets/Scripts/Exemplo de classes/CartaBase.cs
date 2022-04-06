using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nova carta", menuName = "Carta")]
public class CartaBase : ScriptableObject
{
    public string nome;
    [TextArea(4, 20)] public string efeito;
    public uint vida;
    public uint ataque;
    public uint defesa;
    public uint magia;
    [Range(0, 100)] public int custo;

    public void Info()
    {
        Debug.Log(nome);
        Debug.Log(efeito);
        Debug.Log(vida);
        Debug.Log(ataque);
        Debug.Log(defesa);
        Debug.Log(magia);
        Debug.Log(custo);
    }
}
