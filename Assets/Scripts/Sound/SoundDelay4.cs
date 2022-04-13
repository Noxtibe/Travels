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
        while (true)
        {
            yield return new WaitForSeconds(12);
            FindObjectOfType<AudioManager4>().Play("SoundSoul4");
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
