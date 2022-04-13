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
        while (true)
        {
            yield return new WaitForSeconds(3);
            FindObjectOfType<AudioManager2>().Play("SoundSoul2");
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
