using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_cube : MonoBehaviour
{
    public int dir;//0 = x,1 = y,2 = zなら方向に動く
    public float area;//動く範囲
    public float speed;//動く速さ
    float moveA = 0;
    bool moveF = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {


        // transformを取得
        Transform myTransform = this.transform;

        if (moveA == 0)
        {
            moveF = true;
        }

        if (moveA == area)
        {
            moveF = false;
        }
        // 座標を取得
        Vector3 pos = myTransform.position;
        if (moveF == true && dir == 0)
        {
            pos.x += speed;    // x座標へ0.01加算
            moveA++;
        }

        if (moveF == false && dir == 0)
        {
            pos.x -= speed;    // x座標へ0.01減算
            moveA--;
        }

        if (moveF == true && dir == 1)
        {
            pos.y += speed;    // y座標へ0.01加算
            moveA++;
        }

        if (moveF == false && dir == 1)
        {
            pos.y -= speed;    // y座標へ0.01減算
            moveA--;
        }

        if (moveF == true && dir == 2)
        {
            pos.z += speed;    // z座標へ0.01加算
            moveA++;
        }

        if (moveF == false && dir == 2)
        {
            pos.z -= speed;    // z座標へ0.01減算
            moveA--;
        }
        myTransform.position = pos;  // 座標を設定

    }

}