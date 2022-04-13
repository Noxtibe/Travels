using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDoorScript : MonoBehaviour
{
    public SoundDelay1 soundDelay1;
    public SoundDelay2 soundDelay2;
    public SoundDelay3 soundDelay3;
    public SoundDelay4 soundDelay4;

    public bool soulOne = false;
    public bool soulTwo = false;
    public bool soulThree = false;
    public bool soulFour = false;

    //public bool allSouls = false;

    void Start()
    {
        soundDelay1.GetComponent<SphereCollider>();
        soundDelay2.GetComponent<SphereCollider>();
        soundDelay3.GetComponent<SphereCollider>();
        soundDelay4.GetComponent<SphereCollider>();
    }

    void Update()
    {

        if (soundDelay1.GetComponent<MeshRenderer>().enabled == true)
        {
            soulOne = true;
        }

        if (soundDelay2.GetComponent<MeshRenderer>().enabled == true)
        {
            soulTwo = true;
        }

        if(soundDelay3.GetComponent<MeshRenderer>().enabled == true)
        {
            soulThree = true;
        }

        if(soundDelay4.GetComponent<MeshRenderer>().enabled == true)
        {
            soulFour = true;
        }

        if(soulOne && soulTwo && soulThree && soulFour == true)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            
        }
    }
}
