using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private LevelManager levelManager;
    [SerializeField] private GameObject Raycasting;
    [SerializeField] private GameController gameController;
    public void LockMouse(bool isLock)
    {
        GetComponent<RigidbodyFirstPersonController>().mouseLook.SetCursorLock(isLock);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            levelManager.ResetLevel();
        }
        if (Input.GetButtonDown("Fire1"))
        {   
            if(gameController.IsPause == false)
            Raycasting.GetComponent<Raycasting>().Raycas();
        }
    }
}
