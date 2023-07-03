using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRC.SDK3.ClientSim;

public class eggCollision : MonoBehaviour
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
}
