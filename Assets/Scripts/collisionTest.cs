using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRC.SDK3.ClientSim;

public class collisionTest : MonoBehaviour
{   
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player") || other.GetComponent<ClientSimBehaviour>() != null)
        {   
            Debug.Log($"name: {other.transform.name}");
        }      
    }
}
