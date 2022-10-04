using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float reloadTime = 1f;
    void OnTriggerEnter2D(Collider2D other) 
    {
       if(other.tag == "Player")
        {
            Invoke("ReloadScene", reloadTime);
          
        } 
        
    }
    void ReloadScene()
    {
        SceneManager.LoadScene("Level_1");
    }
}
