using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlay : MonoBehaviour
{
    public AudioSource audioSource;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CollideObject")
        {
            audioSource.Play();
        }
    }

}
