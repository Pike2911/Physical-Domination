using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    [SerializeField] private GameObject phone;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetButtonDown("OpenPhone"))
        {
            if (phone.activeSelf != true)
            {
                    phone.SetActive(true);
            }
            else
            {
                    phone.SetActive(false);
            }
        }
        
        
    }
}
