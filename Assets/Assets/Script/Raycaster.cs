using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class Raycaster : MonoBehaviour
{
    [SerializeField] GameObject formularUI;
    private void Start()
    {
    }
    void Update()
    {
        int layerMask = 1 << 8;

        Debug.DrawRay(transform.position, Camera.main.transform.forward * 100, Color.red);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                if (hit.collider != null)
                {
                    formularUI.SetActive(true);
                    formularUI.GetComponent<PhyisicUI>().SetActiveCube(hit.collider.gameObject);
                    GameObject player = GameObject.FindGameObjectWithTag("Player");
                    player.GetComponent<RigidbodyFirstPersonController>().mouseLook.SetCursorLock(false);
                    Time.timeScale = 0;
                    this.enabled = false;
                }
            }
        }
    }
}
