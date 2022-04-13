using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDelay3 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(TimeSoundDelay3());
    }

    IEnumerator TimeSoundDelay3()
    {
        while (GetComponent<MeshRenderer>().enabled == false)
        {
            yield return new WaitForSeconds(9);
            FindObjectOfType<AudioManager3>().Play("SoundSoul3");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().enabled = true;
            FindObjectOfType<AudioManager3>().Play("Disintegrate");
            gameObject.GetComponent<SphereCollider>().enabled = false;
            //FindObjectOfType<AudioManager3>().Stop("SoundSoul3");
            //Destroy(gameObject, 3);
        }
    }
}
