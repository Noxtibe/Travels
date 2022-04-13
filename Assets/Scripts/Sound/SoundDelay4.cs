using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDelay4 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(TimeSoundDelay4());
    }

    IEnumerator TimeSoundDelay4()
    {
        while (GetComponent<MeshRenderer>().enabled == false)
        {
            yield return new WaitForSeconds(12);
            FindObjectOfType<AudioManager4>().Play("SoundSoul4");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().enabled = true;
            FindObjectOfType<AudioManager4>().Play("Disintegrate");
            gameObject.GetComponent<SphereCollider>().enabled = false;
            //FindObjectOfType<AudioManager4>().Stop("SoundSoul4");
            //Destroy(gameObject, 3);
        }
    }
}
