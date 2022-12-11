using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {   
        if (other.CompareTag("opendoor"))
        {
            Debug.Log("hi");
        }  
    }
}
