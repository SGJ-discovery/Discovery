/***********************************************************************/
/*! @file   PlayerMove.cs
*************************************************************************
*   @brief  プレイヤーを動かすスクリプト
*************************************************************************
*   @author yuta takatsu
*************************************************************************
*   Copyright © 2017 yuta takatsu All Rights Reserved.
************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool down = false;
    private float _prevX;
    private float speed = 3.0f;
    private Vector3 _delta = new Vector3(0.0f, 0.0f, 0.0f);

    void Update()
    {
        // 上下左右に移動(キーボード)
        if (Input.GetKey("w") || Input.GetAxisRaw("Vertical") < 0)
        {
            this.transform.position += transform.forward * 0.1f;
            //this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        }
        if (Input.GetKey("s"))
        {
            this.transform.position -= transform.forward * 0.1f;
        }
        if (Input.GetKey("d"))
        {
            this.transform.position += transform.right * 0.1f;
        }
        if (Input.GetKey("a"))
        {
            transform.position -= transform.right * 0.1f;
        }

        // マウスでの向き変更

        // マウスをクリックしたときその座標を取得する
        if (Input.GetMouseButtonDown(0))
        {
            _delta.x = 0.0f;
            _delta.y = 0.0f;
            _delta.z = 0.0f;
            _prevX = Input.mousePosition.x;
            down = true;
        }

        // マウスを話したとき
        if (Input.GetMouseButtonUp(0))
        {
            down = false;
        }

        if (down)
        {
            _delta.x = (_prevX - Input.mousePosition.x) / 10;

            _prevX = Input.mousePosition.x;

            Vector3 euler = new Vector3(_delta.y, _delta.x, _delta.z);
            this.transform.Rotate(euler, Space.World);
        }


        // ゲームコントローラー
        //Walk
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * 1); //正面
        }

        //Direction of Caracter's face
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            transform.rotation = Quaternion.LookRotation(transform.position +
            (Vector3.right * Input.GetAxisRaw("Horizontal")) +
            (Vector3.forward * Input.GetAxisRaw("Vertical"))
            - transform.position);
        }
    }
}