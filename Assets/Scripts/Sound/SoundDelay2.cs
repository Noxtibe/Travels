using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDelay2 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(TimeSoundDelay2());
    }

    IEnumerator TimeSoundDelay2()
    {
        while (GetComponent<MeshRenderer>().enabled == false)
        {
            yield return new WaitForSeconds(6);
            FindObjectOfType<AudioManager2>().Play("SoundSoul2");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().enabled = true;
            FindObjectOfType<AudioManager2>().Play("Disintegrate");
            gameObject.GetComponent<SphereCollider>().enabled = false;
            //FindObjectOfType<AudioManager2>().Stop("SoundSoul2");
            //Destroy(gameObject, 3);
        }
    }
}
