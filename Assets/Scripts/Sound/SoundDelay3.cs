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
        while (true)
        {
            yield return new WaitForSeconds(8);
            FindObjectOfType<AudioManager3>().Play("SoundSoul3");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
        }
    }
}
