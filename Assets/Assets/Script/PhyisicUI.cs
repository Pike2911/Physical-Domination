using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityStandardAssets.Characters.FirstPerson;

public class PhyisicUI : MonoBehaviour
{
    private GameObject activeCube;

    [SerializeField] private TMP_InputField textU;
    [SerializeField] private TMP_InputField textV;
    [SerializeField] private TMP_InputField textT;
    [SerializeField] private TMP_InputField textS;
    public void SetActiveCube(GameObject cube)
    {
        activeCube = cube;
        MyPhysic physic = cube.GetComponent<MyPhysic>();

        textU.text = physic.U.ToString();
        textV.text = physic.V.ToString();
        textT.text = physic.T.ToString();
        textS.text = physic.S.ToString();
    }

    public void Activatecube()
    {
        Debug.Log("Call Func");
        MyPhysic physic = activeCube.GetComponent<MyPhysic>();
        physic.U = float.Parse(textU.text);
        physic.T = float.Parse(textT.text);

        activeCube.GetComponent<MyPhysic>().Activephysic();

        
        GameController gameController = GameObject.FindGameObjectWithTag("GameController")
                                                   .GetComponent<GameController>();
        gameController.PauseGame(false);

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<RigidbodyFirstPersonController>().mouseLook.SetCursorLock(true);
        gameObject.SetActive(false);
    }
}
