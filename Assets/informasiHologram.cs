using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class informasiHologram : MonoBehaviour
{
    public string namaProduk;
    public int harga;
    public TextMeshProUGUI textNamaBarang,textHargaBarang;
    // Start is called before the first frame update
    void Start()
    {
        textNamaBarang.text = namaProduk;
        textHargaBarang.text = harga.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
