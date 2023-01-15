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
        Physic physic = cube.GetComponent<Physic>();
        textU.text = physic.U.ToString();
    }
    public void Activatecube()
    {
        Debug.Log("Call Func");
        Physic physic = activeCube.GetComponent<Physic>();
        physic.U = float.Parse(textU.text);

        activeCube.GetComponent<Physic>().Activephysic();
        Time.timeScale = 1.0f;
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<RigidbodyFirstPersonController>().mouseLook.SetCursorLock(true);
        gameObject.SetActive(false);
    }
}
