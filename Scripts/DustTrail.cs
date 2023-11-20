using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
   
   [SerializeField] ParticleSystem effettoNeve;


    private void OnCollisionEnter2D(Collision2D other) {
        
        if(other.gameObject.tag == "Terreno"){
            effettoNeve.Play();
        }
        
    }

    private void OnCollisionExit2D(Collision2D other) {
         if(other.gameObject.tag == "Terreno"){
             effettoNeve.Stop();
        }
    }

}
