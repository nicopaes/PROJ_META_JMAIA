using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenCollision : MonoBehaviour
{
    public int chickenCount = 0;

    public AudioSource audioSource;

    public void OnCollisionEnter(Collision collision)
    {
        if (other.CompareTag("Player") || other.GetComponent<ClientSimBehaviour>() != null)
        {
            audioSource.Play();
            chickenCount++;
        }
    }
}
