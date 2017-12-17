using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAitem : MonoBehaviour
{

    private bool hitFlag; // 当たったかどうかのフラグ
    private GameObject obj; // 当たったオブジェクトを格納する
    private GameObject getObj = null; // 取得したアイテムを格納

    GameObject Kyoutaku;

    bool PutFlg = false;



    void Start()
    {
        hitFlag = false;

        Kyoutaku = GameObject.FindWithTag("Kyoutaku");
    }

    // トリガーとの接触時に呼ばれるコールバック
    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Aitem"))
        {
            Debug.Log("hit");
            hitFlag = true;
            obj = hit.gameObject;
        }
        else
        {
            hitFlag = false;
        }


        if (hit.CompareTag("Kyoutaku"))
        {

            PutFlg = true;
        }


    }

    void Update()
    {


        //取得
        if (Input.GetKeyDown("e"))
        {

            getObj = obj.gameObject;
            //Debug.Log(getObj);

            SelectItem();

            Destroy(obj.gameObject);
            hitFlag = false;
        }



    }

    void SelectItem()
    {


        if (getObj.name == "pencil")
        {

            Kyoutaku.SendMessage("pencil");
        }

        if (getObj.name == "eraser")
        {

            Kyoutaku.SendMessage("eraser");

        }
        if (getObj.name == "dictionary")
        {

            Kyoutaku.SendMessage("dictionary");

        }


    }
}

   