﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private GameObject player;   //プレイヤー情報格納用
    private Vector3 offset;      //相対距離取得用

    // Start is called before the first frame update
    void Start()
    {
        //Playerの情報を取得
        this.player = GameObject.Find("Player");

        // MainCamera(自分自身)とplayerとの相対距離を求める
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //新しいトランスフォームの値を代入する
        transform.position = player.transform.position + offset;
    }
}
