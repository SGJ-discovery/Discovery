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
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreateStage : MonoBehaviour {

    [SerializeField]
    private GameObject[] stagePrefab; // ステージのプレハブを格納
    private GameObject createStage;   // 生成するオブジェクトを格納
    public static int stageNum;       // 現在のステージのナンバー

    [SerializeField]
    private GameObject CanvasPrefab; // Canvasのプレハブを格納
    private GameObject CreateCanvas; // 生成するオブジェクトを格納

    void Start () {
        stageNum = 0;
        createStage = Instantiate(stagePrefab[stageNum], this.transform);

        CreateCanvas = Instantiate(CanvasPrefab, this.transform.root);
    }
	
    public void StageCreate()
    {
        stageNum++;
        GameObject.Destroy(createStage);
        GameObject.Destroy(CreateCanvas);
        createStage = Instantiate(stagePrefab[stageNum], this.transform);
        CreateCanvas = Instantiate(CanvasPrefab, this.transform.root);

        
    }
    void Update()
    {
        //if (Input.GetKeyDown("n"))
        //{
        //    StageCreate();
        //}
    }

    public int GetStagePrefab()
    {
        return stagePrefab.Length;
    }
}
