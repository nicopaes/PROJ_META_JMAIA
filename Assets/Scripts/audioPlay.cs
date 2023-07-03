using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlay : MonoBehaviour
{
    public AudioSource audioSource;

    public void OnCollisionEnter(Collision other)
    {
        if (other.CompareTag("Player") || other.GetComponent<ClientSimBehaviour>() != null)
        {
            audioSource.Play();
        }
    }

}
