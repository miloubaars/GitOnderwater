using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdateScript : MonoBehaviour
{
         
    void OnTriggerEnter(Collider other)
    {
        ScoreScript.theScore += 1;

    }
}
