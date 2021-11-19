using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adaPetunjukTidak : MonoBehaviour
{
    public bool petunjukAktif;
    public GameObject petunjuk,petunjukTerakhir;
    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log(PlayerPrefs.GetInt("petunjuk"));
        if (PlayerPrefs.GetInt("petunjuk") == 0)
        {
            petunjuk.SetActive(true);
            petunjukAktif = true;
        }
        else
        {
            petunjuk.SetActive(false);
            petunjukAktif = false;
        }
        //untuk reset playerprefres
        //PlayerPrefs.SetInt("petunjuk", 1);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void selesaiPetunjuk()
    {
        petunjukTerakhir.SetActive(false);
        PlayerPrefs.SetInt("petunjuk", 1);
    }
}
