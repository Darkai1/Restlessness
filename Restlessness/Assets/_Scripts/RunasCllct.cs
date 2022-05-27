using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunasCllct : MonoBehaviour
{
    [SerializeField]
    private AudioClip _heartPickUpSound;


    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            //if (Input.GetKeyDown(KeyCode.E))
            //{
                //Player player = other.GetComponent<Player>();
                //if (player != null)
                //{
                    GameManager.Instance.playerwinner(1);
                    Debug.Log("Runa");
                    
                    AudioSource.PlayClipAtPoint(_heartPickUpSound, transform.position, 1f);
                    Destroy(this.gameObject);

                //}
            //}
        }
    }
}
