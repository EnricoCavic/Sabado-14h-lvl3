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

    // a velocidade de movimente deste personagem
    public float velocidade;

    bool podeSeguir;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        meuRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector3.Distance( playerTransform.position, transform.position );

        podeSeguir = distancia < campoDeVisao;

        if( podeSeguir )
        {
            transform.LookAt(playerTransform);

            Vector3 dir = transform.forward * velocidade; 
            meuRb.AddForce(dir, ForceMode.Force);
        }

    }
}
