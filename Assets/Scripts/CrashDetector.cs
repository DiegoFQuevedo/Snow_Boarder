using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadTime = 1f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSfx;
    bool hasCrashed = false;

    
  
    void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSfx);
            Invoke("ReloadScene",reloadTime);
        }
    }
    
    void ReloadScene()
    {
        SceneManager.LoadScene("Level_1");
    }

}
