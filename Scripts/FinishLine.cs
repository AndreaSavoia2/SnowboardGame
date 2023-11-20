using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float tempoDiRicaricaScena = 1f;
    [SerializeField] ParticleSystem effettoFinale;
    void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "Player"){
            FindAnyObjectByType<PlayerController>().DisattivaControlli();
            effettoFinale.Play();
            GetComponent<AudioSource>().Play();
            Invoke("RicaricaScena",tempoDiRicaricaScena);
            
        }
        
    }

    void RicaricaScena(){
        SceneManager.LoadScene(0);
    }
}
