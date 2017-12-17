/***********************************************************************/
/*! @file   CreateStage.cs
*************************************************************************
*   @brief  ステージを生成するスクリプト
*************************************************************************
*   @author yuta takatsu
*************************************************************************
*   Copyright © 2017 yuta takatsu All Rights Reserved.
************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateStage : MonoBehaviour {

    [SerializeField]
    private GameObject[] stagePrefab; // ステージのプレハブを格納
    private GameObject createStage;   // 生成するオブジェクトを格納
    public static int stageNum;       // 現在のステージのナンバー

	void Start () {
        stageNum = 0;
        createStage = Instantiate(stagePrefab[stageNum], this.transform);
    }
	
    public void StageCreate()
    {
        GameObject.Destroy(createStage);
        stageNum++;
        createStage = Instantiate(stagePrefab[stageNum], this.transform);

    }
    void Update()
    {
        if (Input.GetKeyDown("n"))
        {
            StageCreate();
        }
    }
}
