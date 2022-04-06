using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAula : MonoBehaviour
{
    // Declarando variáveis
    string nome = "Georginho81";
    int idade = 10;
    float altura = 1.40f;
    string senha = "12345";
    bool sou_aluno = true;

    Rigidbody meuRb;
    // Declarando variável do tipo RIGIDBODY


    // Roda uma vez no começo do jogo
    void Start()
    {
        meuRb = GetComponent<Rigidbody>();
        // Falando para o programa que meuRb é o meu RIGIDBODY
    }

    // Acontece uma vez a cada frame
    void Update()
    {
        meuRb.AddForce(new Vector3(0f,1f,0f), ForceMode.Impulse);
        // Todo frame aplicando Força de Impulso ao meu RIGIDBODY
        // na direção Y       
    }
}
