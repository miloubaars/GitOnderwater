using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera;

    public void Knop()
    {
        Player.SetActive(true);
        Camera.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Spel gestopt. yaay");
    }

}
