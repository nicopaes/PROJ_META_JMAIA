using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRC.SDK3.ClientSim;

public class audioPlay : MonoBehaviour
{
    public AudioSource audioSource;

    public void OnCollisionEnter(Collision other)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.GetComponent<ClientSimBehaviour>() != null)
        {
            audioSource.Play();
        }
    }

}
