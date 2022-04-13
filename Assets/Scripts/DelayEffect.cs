using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayEffect : MonoBehaviour
{
    IEnumerator DelayMaterial()
    {
        yield return new WaitForSeconds(3);
    }

    void Update()
    {
        if(GetComponent<MeshRenderer>().enabled == true)
        {
            StartCoroutine(DelayMaterial());
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().enabled = true;
            Debug.Log("Destroy");
            Destroy(gameObject, 5);
        }
    }
}
