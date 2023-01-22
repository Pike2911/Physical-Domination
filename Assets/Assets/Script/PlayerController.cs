using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private LevelManager levelManager;
    public void LockMouse(bool isLock)
    {
        GetComponent<RigidbodyFirstPersonController>().mouseLook.SetCursorLock(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            levelManager.ResetLevel();
        }
    }
}
