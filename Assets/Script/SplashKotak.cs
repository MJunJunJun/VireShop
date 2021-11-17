using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashKotak : MonoBehaviour
{
    public string nama;
    public int loadScene;




    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == nama)
        {
            Debug.Log("HEH!");
            SceneManager.LoadScene(loadScene);
        }

        


    }







}
