using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physic : MonoBehaviour
{
    [SerializeField] float u = 0;
    [SerializeField] float v = 0;
    [SerializeField] float t = 0;
    [SerializeField] float s = 0;

    private float z = 0;

    private Vector3 Location;
    private void Start()
    {
        Location = transform.position;
        z = transform.position.x;
    }
    private void Update()
    {
        t += Time.deltaTime;
        s = (u + v) / 2.0f * t;
        Location.x = z + s;
        transform.position = Location;
        Debug.Log(s);
        if(t >= 5)
        {
            this.enabled = false;
        }
    }
}
