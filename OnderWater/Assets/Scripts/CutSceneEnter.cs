using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutSceneEnter : MonoBehaviour
{
    public GameObject thePlayer;
    public PlayableDirector timeline;
    public GameObject Vis;
 

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<SphereCollider>().enabled = false;       
        timeline.Play();
        thePlayer.SetActive(false);
        StartCoroutine(FinishCut());
    }

    System.Collections.IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(25);
        thePlayer.SetActive(true);
        timeline.Stop();
        Vis.SetActive(true);
    }
    
}
