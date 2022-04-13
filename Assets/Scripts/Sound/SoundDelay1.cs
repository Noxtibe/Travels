using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDelay1 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(TimeSoundDelay1());
    }

    IEnumerator TimeSoundDelay1()
    {
        /*yield return new WaitForSeconds(3);
        FindObjectOfType<AudioManager>().Play("SoundSoul4");*/

        while(true)
        {
            yield return new WaitForSeconds(4);
            FindObjectOfType<AudioManager1>().Play("SoundSoul1");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
