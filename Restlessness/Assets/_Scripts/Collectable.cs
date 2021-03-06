using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField]
    private AudioClip _coinPickUpSound;


    
    public void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        { 
           Player player = other.GetComponent<Player>();
           if(player != null)
           { 
              player.hasCoin=true; 
              AudioSource.PlayClipAtPoint(_coinPickUpSound, transform.position, 1f);
              Destroy(this.gameObject);

           }
          
        }
    }

}
