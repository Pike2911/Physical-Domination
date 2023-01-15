using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodoor : MonoBehaviour
{
    [SerializeField] GameObject movingDoor;

    private float maximumOpening = 11f;

    private float movementSpeed = 5f;

    bool cubeIsHere;

    // Start is called before the first frame update
    void Start()
    {
        cubeIsHere = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cubeIsHere)
        {
            if (movingDoor.transform.position.y < maximumOpening)
            {
                movingDoor.transform.Translate(0f, movementSpeed * Time.deltaTime, 0f);
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "opendoor")
        {
            cubeIsHere = true;
        }
    }
}
