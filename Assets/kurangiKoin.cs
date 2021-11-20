using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class kurangiKoin : MonoBehaviour
{
    public TextMeshProUGUI textCoin1, textCoin2, textCoin3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void coinClick()
    {
        textCoin1.text = textCoin2.text = textCoin3.text = (999 - 50).ToString();
    }
}
