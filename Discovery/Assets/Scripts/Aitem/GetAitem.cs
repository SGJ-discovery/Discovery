using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAitem : MonoBehaviour
{

    private bool hitFlag; // 当たったかどうかのフラグ
    private GameObject obj; // 当たったオブジェクトを格納する
    private GameObject getObj = null; // 取得したアイテムを格納
    [SerializeField]
    private GameObject menu;
    private static SelectMenu _menu;

    GameObject Kyoutaku;

    bool PutFlg = false;



    void Start()
    {
        hitFlag = false;
        _menu = menu.GetComponent<SelectMenu>();
        Debug.Log("_menu : " + _menu);
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
            //hitFlag = false;
        }


        if (hit.CompareTag("Kyoutaku"))
        {

            PutFlg = true;
        }


    }

    void Update()
    {


        //取得
        if (Input.GetKeyDown("e")&&hitFlag|| Input.GetButtonDown("Fire1")&&hitFlag)
        {

            getObj = obj.gameObject;
            Debug.Log(getObj);
            //SelectItem();

            //Destroy(obj.gameObject);
            _menu.SetItem(getObj);
            hitFlag = false;
        }



    }

    //void SelectItem()
    //{


    //    if (getObj.name == "pencil(Clone)")
    //    {

    //        Kyoutaku.SendMessage("pencil");
    //    }

    //    if (getObj.name == "eraser(Clone)")
    //    {

    //        Kyoutaku.SendMessage("eraser");

    //    }
    //    if (getObj.name == "dictionary(Clone)")
    //    {

    //        Kyoutaku.SendMessage("dictionary");

    //    }


    //}
}

   