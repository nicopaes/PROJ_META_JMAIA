using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRC.SDK3.ClientSim;

public class audioPlay : MonoBehaviour
{
    public AudioSource audioSource;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.GetComponent<ClientSimBehaviour>() != null)
        {
            Debug.Log("This collision is happening");
            audioSource.Play();
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Board Collision");
        if (other.gameObject.CompareTag("Player") || other.gameObject.GetComponent<ClientSimBehaviour>() != null)
        {
            Debug.Log("Board Collision WITH PLAYER");
            audioSource.Play();
        }
    }

}
