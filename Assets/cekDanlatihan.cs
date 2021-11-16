using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cekDanlatihan : MonoBehaviour
{
    public void Start()
    {
        textCek.text = PlayerPrefs.GetString("value");
    }
    public TextMeshProUGUI textCek;
    public void cekFunction()
    {
        Cek cek = APIHelper.getNewCek();
        textCek.text = cek.value;
        PlayerPrefs.SetString("value",cek.value);
    }
}
