using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Quit Game");
        Application.Quit();
        //SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
    }
}
