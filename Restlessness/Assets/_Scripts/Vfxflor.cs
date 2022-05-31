using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vfxflor : MonoBehaviour
{
    public GameObject VFX;
    public GameObject Sangre;

    public void Start()
     {
        if(VFX!=null)
         VFX.SetActive(false);
        if(Sangre!=null)
         Sangre.SetActive(false);
     }
     
  
    public void OnTriggerStay(Collider other)
    {
        Debug.Log("Ingresa Player");
        if (other.tag == "Player")
        {
            Debug.Log("Ingresa Player");
            VFX.SetActive(true);
            Sangre.SetActive(true);
        }
    }

     public void OnTriggerExit(Collider other)
    {
        Debug.Log("Ingresa Player");
        if (other.tag == "Player")
        {
            Debug.Log("Ingresa Player");
            VFX.SetActive(false);
            Sangre.SetActive(false);
        }
    }
    
}