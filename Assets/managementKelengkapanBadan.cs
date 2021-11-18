using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managementKelengkapanBadan : MonoBehaviour
{
    public string nama;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == nama)
        {
            Debug.Log("HEH!");
        }
        
    }



     /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name=="box")
        {
            Destroy(collision.gameObject);
        }
    }*/

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("TriggerObject"))
        {
            Destroy(other.gameObject);
        }
    }*/






}
