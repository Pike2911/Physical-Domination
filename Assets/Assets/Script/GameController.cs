using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameController : MonoBehaviour
{
    [SerializeField] private UnityEvent onPause;
    [SerializeField] private UnityEvent unPause;

    private bool isPause = false;

    public bool IsPause { get => isPause; set => isPause = value; }

    public void PauseGame(bool isPause)
    {
        Time.timeScale = isPause ? 0 : 1;
        this.IsPause = isPause;
        if (isPause)
        {
             onPause.Invoke();
        }
        else
        {
            unPause.Invoke();
        }
    }
}
