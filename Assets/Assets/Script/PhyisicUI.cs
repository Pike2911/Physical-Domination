using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityStandardAssets.Characters.FirstPerson;

public class PhyisicUI : MonoBehaviour
{
    private GameObject activeCube;

    [SerializeField] private TMP_InputField textU;
    public void SetActiveCube(GameObject cube)
    {
        activeCube = cube;
        MyPhysic physic = cube.GetComponent<MyPhysic>();
        textU.text = physic.U.ToString();
    }
    public void Activatecube()
    {
        Debug.Log("Call Func");
        MyPhysic physic = activeCube.GetComponent<MyPhysic>();
        physic.U = float.Parse(textU.text);

        activeCube.GetComponent<MyPhysic>().Activephysic();
        Time.timeScale = 1.0f;
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<RigidbodyFirstPersonController>().mouseLook.SetCursorLock(true);
        gameObject.SetActive(false);
    }
}
