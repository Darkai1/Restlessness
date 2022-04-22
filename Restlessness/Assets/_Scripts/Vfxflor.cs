using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vfxflor : MonoBehaviour
{
    public GameObject test;

    public void Start() {
        if(test!=null)
         test.SetActive(false);
     }
  
    public void OnTriggerStay(Collider other)
    {
        Debug.Log("Ingresa Player");
        if (other.tag == "Player")
        {
            Debug.Log("Ingresa Player");
            test.SetActive(true);
        }
    }

     public void OnTriggerExit(Collider other)
    {
        Debug.Log("Ingresa Player");
        if (other.tag == "Player")
        {
            Debug.Log("Ingresa Player");
            test.SetActive(false);
        }
    }
}