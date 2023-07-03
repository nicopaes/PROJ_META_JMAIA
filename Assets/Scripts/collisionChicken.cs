using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRC.SDK3.ClientSim;

public class collisionChicken : MonoBehaviour
{
    public int chickenCount = 0;

    public AudioSource audioSource;

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"TAG {collision.gameObject.tag}");
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.GetComponent<ClientSimBehaviour>() != null)
        {
            audioSource.Play();
            chickenCount++;
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Chicken Collision");
        if (other.gameObject.CompareTag("Player") || other.gameObject.GetComponent<ClientSimBehaviour>() != null)
        {
            Debug.Log("Chicken Collision WITH PLAYER");
            audioSource.Play();
            chickenCount++;
        }
    }
}
