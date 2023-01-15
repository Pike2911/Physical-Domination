using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class PlayerController : MonoBehaviour
{
    public void LockMouse(bool isLock)
    {
        GetComponent<RigidbodyFirstPersonController>().mouseLook.SetCursorLock(false);
    }
}
