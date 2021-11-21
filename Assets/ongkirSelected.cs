using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ongkirSelected : MonoBehaviour
{
    public BeliLangsung infoBeli;
    public GameObject selected, Unselect, otherSelect, otherUnselect;
    public int ongkir,total;
    public TextMeshProUGUI textOngkir,textTotalHarga, textTotalHarga2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void siCepat()
    {
        infoBeli.ongkir = 25;
        Selecteed();
        textOngkir.text = ongkir.ToString();
        total = ongkir + 40;
        textTotalHarga.text =textTotalHarga2.text= total.ToString();
    }
    public void jNt()
    {
        infoBeli.ongkir = 23;
        Selecteed();
        textOngkir.text = ongkir.ToString();
        total = ongkir + 40;
        textTotalHarga.text = textTotalHarga2.text = total.ToString();

    }
    public void Selecteed()
    {
        selected.SetActive(true);
        Unselect.SetActive(false);
        otherSelect.SetActive(false);
        otherUnselect.SetActive(false);
    }


}
