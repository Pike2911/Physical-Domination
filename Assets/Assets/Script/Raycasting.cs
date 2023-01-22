using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Raycasting : MonoBehaviour
{
    public GameObjectEvent onHit;

    [SerializeField] GameObject formularUI;
    private void Start()
    {
        
    }
    void Update()
    {
        int layerMask = 1 << 8;

        Debug.DrawRay(transform.position, Camera.main.transform.forward * 100, Color.red);

        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                if (hit.collider != null)
                {
                    onHit.Invoke(hit.collider.gameObject);
                    
                }
            }
        }
    }
}
