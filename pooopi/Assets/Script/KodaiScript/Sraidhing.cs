using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sraidhing : MonoBehaviour
{
    public Player player;
    private float heightPos;

    void Start()
    {
        heightPos = 0;
    }

    void Update()
    {
        Transform NullTransform = GameObject.Find("PlayerObj").transform;
        Vector3 Scale = NullTransform.localScale;
        if (player.isSraidhing)
        {
            Scale.y = 1.0f;
        }
        else if (!player.isSraidhing)
        {
            Scale.y = 2.0f;
        }
        transform.localScale = Scale;
    }
}