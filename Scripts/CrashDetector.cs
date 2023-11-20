using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float tempoDiRicaricaScenaCaduta = 0.5f;
    [SerializeField] ParticleSystem crashEffetto;
    [SerializeField] AudioClip audioCaduta;
    bool caduto = false;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Terreno"){
            
            if (!caduto){
                caduto=true;
                FindAnyObjectByType<PlayerController>().DisattivaControlli();
                crashEffetto.Play();
                GetComponent<AudioSource>().PlayOneShot(audioCaduta);
                
                Invoke("RicaricaScenaCaduta",tempoDiRicaricaScenaCaduta);
            }
            
        }
    }
    
    void RicaricaScenaCaduta(){
        SceneManager.LoadScene(0);
    }
}
