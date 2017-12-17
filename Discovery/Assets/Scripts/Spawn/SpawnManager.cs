/***********************************************************************/
/*! @file   SpawnManager.cs
*************************************************************************
*   @brief  オブジェクト生成を管理するマネージャークラス
*************************************************************************
*   @author yuta takatsu
*************************************************************************
*   Copyright © 2017 yuta takatsu All Rights Reserved.
************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class SpawnManager : MonoBehaviour {

    [SerializeField]
    private GameObject[] spawnArrey; // 生成位置を格納する配列
    [SerializeField]
    private GameObject[] spawnObject; // 生成したいオブジェクトを入れとく

    private int num; // 要素数


    public void Start()
    {
        for(int i = 0; i < spawnArrey.Length; i++)
        {
            if (i < 3)
            {
                num = i;
            }
            else
            {
               num = UnityEngine.Random.Range(0, spawnObject.Length); // 乱数値取得
            }

            Instantiate(spawnObject[num], spawnArrey[i].transform);
        }


    }

}
