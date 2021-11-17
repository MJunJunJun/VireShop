using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showhide : MonoBehaviour
{
    public GameObject objek;

    public void Enable()
    {
        objek.SetActive(true);
    }
    public void Disable()
    {
        objek.SetActive(false);
    }
}
