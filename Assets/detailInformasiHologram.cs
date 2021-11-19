using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class detailInformasiHologram : MonoBehaviour
{
    public string namaProduk;
    public int harga;
    public string deskripsi;
    public TextMeshProUGUI textNamaBarang, textHargaBarang,deskripsiProduk;
    public BeliLangsung infoBeliLangssung;
    // Start is called before the first frame update
    void Start()
    {
        textNamaBarang.text = namaProduk;
        textHargaBarang.text = harga.ToString();
        deskripsiProduk.text = deskripsi;
    }

    public void klik()
    {
        infoBeliLangssung.namaProduk = namaProduk;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
