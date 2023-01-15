using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public void PauseGame(bool isPause)
    {
        Time.timeScale = isPause ? 0 : 1;
    }
}
