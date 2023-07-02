using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionTest : MonoBehaviour
{   
    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log($"tag: {other.tag}");
        Debug.Log($"name: {other.transform.name}");
    }
}
