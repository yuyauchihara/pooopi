using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int dir;//0 = x,1 = y,2 = zなら方向に回る
    public float area;//動く範囲
    public float speed;//動く速さ
    public bool suitti;//trueなら回る falseなら振り子のようになる
    float roteA = 0;
    bool roteF = true;


    void Update()
    {
        // transformを取得
        Transform myTransform = this.transform;

        if (roteA == 0)
        {
            roteF = true;
        }

        if (roteA == area)
        {
            roteF = false;
        }

        if (suitti == true)
        {
            if (dir == 0)
            {
                myTransform.Rotate(speed, 0, 0);
            }

            if (dir == 1)
            {
                myTransform.Rotate(0, speed, 0);
            }

            if (dir == 2)
            {
                myTransform.Rotate(0, 0, speed);
            }
        }

        if (suitti == false)
        {
            if (roteF == true && dir == 0)
            {
                myTransform.Rotate(speed, 0, 0);
                roteA++;
            }
            if (roteF == false && dir == 0)
            {
                myTransform.Rotate(-speed, 0, 0);
                roteA--;
            }

            if (roteF == true && dir == 1)
            {
                myTransform.Rotate(0, speed, 0);
                roteA++;
            }
            if (roteF == false && dir == 1)
            {
                myTransform.Rotate(0, -speed, 0);
                roteA--;
            }

            if (roteF == true && dir == 2)
            {
                myTransform.Rotate(0, 0, speed);
                roteA++;
            }
            if (roteF == false && dir == 2)
            {
                myTransform.Rotate(0, 0, -speed);
                roteA--;
            }
        }
    }

}