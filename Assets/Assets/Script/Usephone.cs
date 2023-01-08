using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usephone : MonoBehaviour
{
    [SerializeField] private GameObject phone;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
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
