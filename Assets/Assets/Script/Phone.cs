using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    [SerializeField] private GameObject phone;
    [SerializeField] private Raycasting raycasting;

    private void Start()
    {
        
    }
    private void Update()
    {
        int currentPower = raycasting.GetPower();

        if(currentPower != 0)
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
        else if(currentPower == 0)
        {
            phone.SetActive(false);
        }
    }
}
