using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightChange : MonoBehaviour
{
    private float heightPos;
    private bool turnPoint;
    int i = 0;

    void Start()
    {
        heightPos = 0;
        turnPoint = false;
    }

    void Update()
    {
        if (i % 240 == 0)
        {
            turnPoint = true;
        }
        else if (i % 240 == 120)
        {
            turnPoint = false;
        }

        if (!turnPoint)
        {
            transform.localScale = new Vector3(1, heightPos, 1);
            heightPos = 1.0f;
        }
        if (turnPoint)
        {
            transform.localScale = new Vector3(1, heightPos, 1);
            heightPos = 5.0f;
        }
        i++;
    }
}