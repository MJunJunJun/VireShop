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
    public TextMeshProUGUI textAlamat, textNamaProduk, textNamaToko, textJumlah, textHargaProduk,hargaProduk2, textOngkir, textJumlahBayar,textJumlahBayar2;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("alamat", "Desa Kedondong Rt04/01 Kecamatan Sokaraja, Kabupaten Banyumas");
        alamat = PlayerPrefs.GetString("alamat");
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
        textHargaProduk.text=hargaProduk2.text = infoDetail.harga.ToString();
        textOngkir.text = ongkir.ToString();
        textJumlahBayar.text = textJumlahBayar2.text = total.ToString();
        textNamaToko.text = NamaToko;

    }
    public void tambahJumlah()
    {
        jumlahBarang++;
        cekInfo();
    }
    public void kurangiJumlah()
    {
        jumlahBarang--;
        if (jumlahBarang <= 0)
        {
            jumlahBarang = 0;
        }
        cekInfo();
    }
}
