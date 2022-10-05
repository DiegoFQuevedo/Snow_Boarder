using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadTime = 1f;
    [SerializeField] ParticleSystem crashEffect;
    
  
    void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("ReloadScene",reloadTime);
        }
    }
    
    void ReloadScene()
    {
        SceneManager.LoadScene("Level_1");
    }

}
