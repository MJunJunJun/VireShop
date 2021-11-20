using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ongkirSelected : MonoBehaviour
{
    public BeliLangsung infoBeli;
    public GameObject selected, Unselect, otherSelect, otherUnselect;
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
    }
    public void jNt()
    {
        infoBeli.ongkir = 23;
        Selecteed();
    }
    public void Selecteed()
    {
        selected.SetActive(true);
        Unselect.SetActive(false);
        otherSelect.SetActive(true);
        otherUnselect.SetActive(false);
    }


}
