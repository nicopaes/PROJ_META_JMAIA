using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRC.SDK3.ClientSim;

public class collisionEgg : MonoBehaviour
{
    public int eggCount = 0;

    public AudioSource audioSource;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.GetComponent<ClientSimBehaviour>() != null)
        {
            audioSource.Play();
            eggCount++;
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Egg Collision");
        if (other.gameObject.CompareTag("Player") || other.gameObject.GetComponent<ClientSimBehaviour>() != null)
        {
            Debug.Log("Egg Collision WITH PLAYER");
            audioSource.Play();
            eggCount++;
        }
    }
}
