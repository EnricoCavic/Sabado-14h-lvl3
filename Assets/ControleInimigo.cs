using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleInimigo : MonoBehaviour
{
    // rigidbody utiliza a física para mover
    Rigidbody meuRb;

    // guarda a posição do jogador
    Transform playerTransform;

    // guarda a distância entre o jogador e o inimigo
    float distancia;

    // distancia mínima que o inimigo precisa estar do jogador para seguir
    public float campoDeVisao;


    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        meuRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
