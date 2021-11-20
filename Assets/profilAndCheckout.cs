using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class profilAndCheckout : MonoBehaviour
{
    public string username, alamat;
    public TextMeshProUGUI textUserName, textAlamat;

    // Start is called before the first frame update
    void Start()
    {
        username = PlayerPrefs.GetString("username");
        alamat = PlayerPrefs.GetString("alamat");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
