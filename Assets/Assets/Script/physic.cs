using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physic : MonoBehaviour
{
    [SerializeField] float u = 0;
    [SerializeField] float v = 0;
    [SerializeField] float t = 0;
    [SerializeField] float s = 0;

    private Vector3 Location;
    private void Start()
    {
        Location = transform.position;
    }
    private void Update()
    {
        t = Time.time;
        s = (u + v) / 2.0f * t;
        Location.x = s;
        transform.position = Location;
        if(t >= 5)
        {
            this.enabled = false;
        }
        
    }
}
