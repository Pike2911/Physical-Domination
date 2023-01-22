using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> objects;

    private Dictionary<GameObject, Vector3> initObjects;

    private void Awake()
    {
        initObjects = new Dictionary<GameObject, Vector3>();
    }
    private void Start()
    {
        foreach(var obj in objects)
        {
            initObjects[obj] = obj.transform.position;
        }

        Debug.Log(initObjects.Count);
    }
    public void ResetLevel()
    {
        foreach (var obj in objects)
        {
            obj.transform.position = initObjects[obj];
        }
        Debug.Log("Complete");
    }
}
