using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeliLangsung : MonoBehaviour
{
    public InfoProfil profil;
    public detailInformasiHologram infoDetail;
    public string alamat, namaProduk, NamaToko, harga;
    public int jumlahBarang,ongkir,total;
    public TextMeshProUGUI textAlamat, textNamaProduk, textNamaToko, textJumlah, textHargaProduk, textOngkir, textJumlahBayar,textJumlahBayar2;
    // Start is called before the first frame update
    void Start()
    {
        alamat = PlayerPrefs.GetString("alaamt");
        profil= GameObject.FindObjectOfType<InfoProfil>();
     
        harga = infoDetail.harga.ToString();
        cekInfo();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void beli()
    {

    }
    public void cekInfo()
    {
        textAlamat.text = alamat;
        textNamaProduk.text = namaProduk;
        total = (infoDetail.harga * jumlahBarang) + ongkir;
        textHargaProduk.text = infoDetail.harga.ToString();
        textOngkir.text = ongkir.ToString();
        textJumlahBayar.text = textJumlahBayar2.text = total.ToString();

    }
}
