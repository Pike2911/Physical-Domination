using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBar : MonoBehaviour
{
    [SerializeField] GameObject Energy1;
    [SerializeField] GameObject Energy2;
    [SerializeField] GameObject Energy3;
    [SerializeField] private Raycasting raycasting;


    private void Start()
    {
            
    }

    private void Update()
    {
        int currentPower = raycasting.GetPower();

        Debug.Log(currentPower);

        if (currentPower == 2)
        {
            Energy1.SetActive(false);
            Debug.Log("ooooooooooooooo");
        }
        else if(currentPower == 1)
        {
            Energy2.SetActive(false);
            Debug.Log("ooooooooooooooo");
        }
        else if(currentPower == 0)
        {
            Energy3.SetActive(false);
        }
    }
}
