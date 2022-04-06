using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePersonagem : MonoBehaviour
{
    float eixoY; 
    float eixoX;

    Animator meuAnimator;
    Rigidbody rb; 

    public float velocidade; 
    public float velocidade_giro;


    // Start is called before the first frame update
    void Start()
    {
        meuAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        eixoY = Input.GetAxis("Vertical");
        eixoX = Input.GetAxis("Horizontal");

        Vector3 dir = transform.forward * velocidade * eixoY;
        rb.AddForce(dir, ForceMode.Force);

        Vector3 giro = transform.up * velocidade_giro * eixoX;
        rb.AddTorque(giro, ForceMode.Force);

        meuAnimator.SetFloat("Y", eixoY);
    }
}
