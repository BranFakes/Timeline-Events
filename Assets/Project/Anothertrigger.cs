using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class Anothertrigger : MonoBehaviour
{
    public PlayableDirector Timeline;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Please god work");
        Timeline.Play();      
    }

}