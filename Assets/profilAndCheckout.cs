using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class profilAndCheckout : MonoBehaviour
{
    public string username, alamat;
    public int coin;
    public TextMeshProUGUI textUserName, textAlamat,textCoin;

    // Start is called before the first frame update
    void Start()
    {
        coin = PlayerPrefs.GetInt("coin");
        username = PlayerPrefs.GetString("username");
        alamat = PlayerPrefs.GetString("alamat");
        textUserName.text = username;
        textAlamat.text = alamat;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
