using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPhysic : MonoBehaviour
{
    [SerializeField] float u = 0;
    [SerializeField] float v = 0;
    [SerializeField] float t = 0;
    [SerializeField] float s = 0;
    [SerializeField] float physicT = 0;

    public float U { get => u; set => u = value; }
    public float V { get => v; set => v = value; }
    public float T { get => t; set => t = value; }
    public float S { get => s; set => s = value; }

    private float z = 0;

    private Vector3 Location;
    private bool isPhysicActive = false;
    private void Start()
    {
        Location = transform.position;
        z = transform.position.x;
    }
    private void Update()
    {
        if (isPhysicActive)
        {
            physicT += Time.deltaTime;
            S = (U + V) / 2.0f * physicT;
            Location.x = z + S;
            transform.position = Location;
            Debug.Log(S);
            if (physicT >= T)
            {
                isPhysicActive = false;
                physicT = 0;
            }
        }
    }
    public void ActivePhysic()
    {
        isPhysicActive = true;
    }
}
