/***********************************************************************/
/*! @file   NextScene.cs
*************************************************************************
*   @brief  次のシーンを登録するスクリプト
*************************************************************************
*   @author yuta takatsu
*************************************************************************
*   Copyright © 2017 yuta takatsu All Rights Reserved.
************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Scene;

public class NextScene : MonoBehaviour
{

    [SerializeField]
    private SCENES nextScene; // 次のシーン格納用

    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.SceneMove(nextScene); // SceneManagerを呼び出す 引数は次のシーン
        }
    }
}