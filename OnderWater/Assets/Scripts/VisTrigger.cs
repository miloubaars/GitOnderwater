using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VisTrigger : MonoBehaviour
{
    public GameObject EindScherm;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            EindScherm.SetActive(true);
            Player.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
        }
        
    }
}
