using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDelay1 : MonoBehaviour
{
    AudioManager1 audioManager1;
    void Start()
    {
        StartCoroutine(TimeSoundDelay1());
        GetComponent<MeshRenderer>().enabled = false;
        audioManager1 = GetComponent<AudioManager1>();
        
    }

    IEnumerator TimeSoundDelay1()
    {
        /*yield return new WaitForSeconds(3);
        FindObjectOfType<AudioManager>().Play("SoundSoul4");*/

        while(GetComponent<MeshRenderer>().enabled == false)
        {
            yield return new WaitForSeconds(3);
            FindObjectOfType<AudioManager1>().Play("SoundSoul1");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().enabled = true;
            FindObjectOfType<AudioManager1>().Play("Disintegrate");
            gameObject.GetComponent<SphereCollider>().enabled = false;
            //FindObjectOfType<AudioManager1>().Stop("SoundSoul1");
            //audioManager1.Stop("SoundSoul1");
            //audioManager1.enabled = false;
            //this.enabled = false;
            //Destroy(gameObject, 3);
        }
    }
}
