using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] float forzaDiRotazione = 1f;
    [SerializeField] float Accelelrazione = 30f;
    [SerializeField] float rallentamento = 20f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    bool movimentoDisponibile = true;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    public void DisattivaControlli(){
        movimentoDisponibile=false;
    }

    void Update()
    {
        if(movimentoDisponibile){
            RotazioneGiocatore();
            RespondToBoost();
        }else if(!movimentoDisponibile){
            DisattivaControlli();
        }
        
    }

    void RespondToBoost()
    {
        
        if (Input.GetKey(KeyCode.W)){
            surfaceEffector2D.speed = Accelelrazione;
        }else if(Input.GetKey(KeyCode.S)){
            surfaceEffector2D.speed = rallentamento;
        }
    }

    void RotazioneGiocatore()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(forzaDiRotazione);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(-forzaDiRotazione);
        }
    }
}
