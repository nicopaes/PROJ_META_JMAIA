using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionTest : MonoBehaviour
{   
    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
            Debug.Log($"name: {other.transform.name}");
        }        
    }
}
